using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Nicholas Chapman-Miller
 * Final Project
 * CPT 185-AO1H
 */
namespace NChapman_Miller_Final_Project
{
    public partial class frmGame : Form
    {
        /*
         * active game objects
         */
        private static readonly Random gameRng = new Random();

        public Player gamer;
        public character_type selectedCharacter;

        private Mob currentEnemy = null;
        private Encounter currentEncounter = null;
        private int currentDepth = 0;
        private bool readyToExplore = true;
        private Room nextRoom;

        /*
         * queue to help game flow with text log
         */
        Queue<Action> eventQueue = new Queue<Action>();
        bool waitingForInput = false;

        /*
         * audio
         */

        private SoundPlayer runSound;
        private SoundPlayer healSound;
        private SoundPlayer encounterSound;
        private SoundPlayer missSound;
        private SoundPlayer enemyEncounter;
        private SoundPlayer victorySound;
        private SoundPlayer reaperSound;
        private SoundPlayer reaperphaseSound;
        private SoundPlayer deathSound;
        private SoundPlayer sadSound;
        private SoundPlayer lvlSound;
        /*
         * entities
         */

        public Mob Goblin = new Mob("Goblin", 15, 15, 7, 6, 70, Properties.Resources.Goblin, 0, 6);
        public Mob Skeleton = new Mob("Skeleton", 10, 10, 4, 5, 65, Properties.Resources.skeleton, 1, 4);
        public Mob Rat = new Mob("Chill Rat", 12, 12, 14, 8, 80, Properties.Resources.Rat, 2, 10);
        public Mob.Boss FinalBoss;
        public Mob empty = new Mob();
        public Mob[] Enemies = new Mob[3];
        public Room BossRoom;

        public Encounter[] Encounters = new Encounter[3];
        public Encounter treasure;
        public Encounter spikePit;
        public Encounter orb;

        /*
         * constructor
         */

        public frmGame(Player gamerGuy)
        {
            InitializeComponent();

            gamer = gamerGuy;

            GameMessages.Output = AddMessage;

            runSound = new SoundPlayer(Properties.Resources.running);
            healSound = new SoundPlayer(Properties.Resources.healing);
            encounterSound = new SoundPlayer(Properties.Resources.goodencounter);
            missSound = new SoundPlayer(Properties.Resources.Miss);
            enemyEncounter = new SoundPlayer(Properties.Resources.enemyencounter);
            victorySound = new SoundPlayer(Properties.Resources.victory);
            reaperSound = new SoundPlayer(Properties.Resources.reapernoise);
            reaperphaseSound = new SoundPlayer(Properties.Resources.reaperphase2sound);
            deathSound = new SoundPlayer(Properties.Resources.deathscream);
            sadSound = new SoundPlayer(Properties.Resources.sadmusic);
            lvlSound = new SoundPlayer(Properties.Resources.lvlupsound);

            treasure = new Encounter(
                "Treasure",
                $"!!! {gamer.Name.ToUpper()} stumbled upon a treasure chest !!!",
                $"!!! {gamer.Name.ToUpper()} opened the chest and found 15 Exp !!!",
                $"!!! The chest was empty :'(  *+1 Exp* !!!",
                Properties.Resources.chestclosed,
                Properties.Resources.chestopen,
                Properties.Resources.chestempty,
                15);

            spikePit = new Encounter(
                "Spike Pit",
                $"!!! AAAAAA * {gamer.Name.ToUpper()} fell in a pit with spikes* AAAAA *-8 HP + 6 Exp*!!!",
                Properties.Resources.spikepit,
                6,
                8);

            orb = new Encounter("Orb", "!!! " + gamer.Name.ToUpper() + " STUMBLED UPON A GLOWING ORB ... " + gamer.Name.ToUpper() + " FEELS POWERFUL * + 20 exp * !!!", Properties.Resources.orb, 20, 0);

            FinalBoss = new Mob.Boss("Green Reaper", 40, 10, 7, 85, Properties.Resources.greenreaper, 3, 50, Properties.Resources.greenreaperstage2, "!!! THE GREEN REAPER HAS ARRIVED TO TAKE BACK THE CASTLE !!!", "!!! THE REAPER IS TRANSFORMING !!!", reaperSound, 25);

            BossRoom = new Room("Boss", false, FinalBoss, treasure);

            Enemies[0] = Goblin;
            Enemies[1] = Skeleton;
            Enemies[2] = Rat;

            Encounters[0] = treasure;
            Encounters[1] = spikePit;
            Encounters[2] = orb;
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            UpdatePlayerStats();
            UpdatePlayerIcon();

            // overlay damage effects
            pBoxPlayerIcon.Controls.Add(pBoxHurt);
            pBoxHurt.Location = new Point(0, 0);
            pBoxHurt.BackColor = Color.Transparent;

            pBoxMob.Controls.Add(pBoxHurtMob);
            pBoxHurtMob.Location = new Point(0, 0);
            pBoxHurtMob.BackColor = Color.Transparent;

            butContinue.Visible = false;
        }

        /*
         * game flow section
         */



        public void QueueEvent(Action action)
        {
            eventQueue.Enqueue(action);
            if (!waitingForInput)
                RunNextEvent();
        }

        public void RunNextEvent()
        {
            if (waitingForInput) return;

            if (eventQueue.Count == 0)
            {
                butContinue.Visible = false;
                readyToExplore = true;
                return;
            }

            Action next = eventQueue.Dequeue();
            next();
        }

        public void PauseForMessage(string msg)
        {
            lblMessage.Text = msg;
            lstBoxLog.Items.Add(msg);
            lstBoxLog.TopIndex = lstBoxLog.Items.Count - 1;

            waitingForInput = true;
            butContinue.Visible = true;
            butAttack.Enabled = false;
            butBlock.Enabled = false;
            butHeal.Enabled = false;
            butRun.Enabled = false;
            butWalk.Enabled = false;
            butLevelUp.Enabled = false;

        }

        private void butContinue_Click_1(object sender, EventArgs e)
        {
            waitingForInput = false;
            butContinue.Visible = false;
            butAttack.Enabled = true;
            butBlock.Enabled = true;
            butHeal.Enabled = true;
            butRun.Enabled = true;
            butWalk.Enabled = true;
            butLevelUp.Enabled = true;
            if (nextRoom.IsExit)
            {
                this.BackgroundImage = Properties.Resources.courtyard;

                nextRoom.IsExit = false;
            }
            RunNextEvent();
        }

        public void AddMessage(string msg)
        {
            QueueEvent(() => PauseForMessage(msg));
        }

        /*
         * Ui stuff
         */

        public void UpdatePlayerStats()
        {
            grpBoxPlayerStats.Text = gamer.Name + "'s stats";
            lblPlayerClass.Text = "Class: " + gamer.BattleClass.Name;
            lblPlayerLevel.Text = "Level: " + gamer.Level;
            lblPlayerHealth.Text = $"{gamer.CurrentHP} / {gamer.BattleClass.MaxHealth}";
            lblPlayerDmg.Text = "Damage: " + gamer.BattleClass.Damage;
            lblPlayerSpd.Text = "Speed: " + gamer.BattleClass.Speed;
            lblPlayerAcc.Text = "Accuracy: " + gamer.BattleClass.Accuracy;
            lblPlayerExp.Text = "Exp: " + gamer.Exp;
            lblDefense.Text = "Defense: " + gamer.BattleClass.Defense;

            pBarHealth.Maximum = gamer.BattleClass.MaxHealth;
            pBarHealth.Value = Math.Max(gamer.CurrentHP, 0);

            pBarJuice.Maximum = 20;
            gamer.Juice = Math.Min(gamer.Juice, 20);
            pBarJuice.Value = gamer.Juice;
            lblJuiceAmt.Text = gamer.Juice.ToString();

            if (gamer.CurrentHP <= 0)
            {
                PauseForMessage($"{gamer.Name.ToUpper()} DIED\nReturning to main menu...");
                pBoxDeath.Image = Properties.Resources.deathscreen;
                pBoxDeath.Visible = true;
                pBoxDeath.BringToFront();

                deathSound.PlaySync();
                sadSound.Play();
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        button.Visible = false;
                    }
                }
                butExit.Visible = true;
                butExit.Location = new Point(459, 323);

            }
        }

        public void UpdatePlayerIcon()
        {
            pBoxPlayerIcon.Image = gamer.BattleClass.Icon;
        }

        public void UpdateMob(Mob enemy)
        {
            if (enemy == null)
            {
                lblMobHealth.Text = "";
                lblMobDmg.Text = "";
                lblMobSpd.Text = "";
                lblMobAcc.Text = "";
                pBoxMob.Image = null;

                return;
            }

            lblMobCurrentHP.Text = enemy.CurrentHp + "/" + enemy.MaxHealth;
            pBarMobHP.Maximum = enemy.MaxHealth;
            pBarMobHP.Value = Math.Max(enemy.CurrentHp, 0);
            lblMobDmg.Text = "Damage: " + enemy.Damage;
            lblMobSpd.Text = "Speed: " + enemy.Speed;
            lblMobAcc.Text = "Accuracy: " + enemy.Accuracy;

            pBoxMob.Image = enemy.Icon;
            if (enemy.CurrentHp == 0)
            {
                enemy.Dead = true;
            }
        }
        private void butHeal_Click(object sender, EventArgs e)
        {
            // 1/2 as efficient in combat
            if (currentEnemy != null)
            {
                QueueEvent(async () =>
                {
                    if (gamer.Juice <= 0)
                    {
                        AddMessage("NO JUICE LEFT!");
                        return;
                    }
                    AddMessage("HEALING IS LESS EFFECTIVE IN COMBAT!");
                    healSound.Play();
                    gamer.Juice = (gamer.Juice / 2) + 5;
                    gamer.Heal();
                    UpdatePlayerStats();
                    PauseForMessage($"{gamer.Name} HEALED!");

                    await gamer.TakeDmg(currentEnemy, pBoxHurt);
                    UpdatePlayerStats();

                });
                return;
            }

            if (gamer.Juice <= 0)
            {
                AddMessage("NO JUICE LEFT!");
                return;
            }

            QueueEvent(() =>
            {
                healSound.Play();
                gamer.Heal();
                UpdatePlayerStats();
                PauseForMessage($"{gamer.Name} HEALED!");
            });
        }
        /*
         * explore 
         */

        private void butWalk_Click(object sender, EventArgs e)
        {
            if (!readyToExplore) return;

            readyToExplore = false;

            QueueEvent(() =>
            {
                runSound.PlaySync();
                gamer.Juice = Math.Min(gamer.Juice + 3, 20);
                UpdatePlayerStats();
            });

            nextRoom = GenerateNextRoom(currentDepth + 1);
            ExploreRoom(nextRoom, currentDepth + 1);
        }

        public Room GenerateNextRoom(int depth)
        {
            Random rng = gameRng;

            bool isExit = depth > 6 && rng.Next(100) < (10 + depth * 5);

            Mob enemy = Enemies[rng.Next(Enemies.Length)];
            Encounter scene = Encounters[rng.Next(Encounters.Length)];

            return new Room($"Castle Room {depth}", isExit, enemy, scene);
        }

        public async Task ExploreRoom(Room room, int depth)
        {
            currentDepth = depth;

            QueueEvent(() =>
                PauseForMessage("Entering: " + room.Name)
            );

            if (room.IsExit)
            {

                QueueEvent(async () =>
                {
                    PauseForMessage($"!!! {gamer.Name.ToUpper()} FOUND THE EXIT !!! {gamer.Name.ToUpper()} FEELS REPLENISHED !!! NOW ENTERING THE COURTYARD... !!!");
                    gamer.CurrentHP = gamer.BattleClass.MaxHealth;
                    gamer.Juice += 10;
                    UpdatePlayerStats();
                    FinalBoss.ResetBoss();
                    await BossCombat(FinalBoss);

                });





                return;
            }
            this.BackgroundImage = Properties.Resources.castle2;
            Random rng = gameRng;
            int roll = rng.Next(3);

            if (roll == 0 || roll == 2)
            {
                StartCombat(room.Enemy);
            }
            else
            {
                StartEncounter(room.Encounter);
            }
        }

        /*
         * non combat encoutners
         */

        public void StartEncounter(Encounter scene)
        {
            currentEncounter = scene;

            QueueEvent(() =>
            {
                encounterSound.Play();
                pBoxMob.Image = scene.Pic;
                PauseForMessage(scene.FirstMessage);
            });

            if (scene.Pic2 == null)
            {
                QueueEvent(() =>
                {
                    gamer.CurrentHP -= scene.Dmg;
                    gamer.Exp += scene.Exp;
                    PauseForMessage(gamer.Name.ToUpper() + " CONTINUES TO EXPLORE");
                    UpdatePlayerStats();
                    pBoxMob.Image = null;
                });
                return;
            }

            Random rng = gameRng;
            bool good = rng.Next(2) == 0;

            if (good)
            {
                QueueEvent(() =>
                {
                    pBoxMob.Image = scene.Pic2;
                    PauseForMessage(scene.LastMessage);
                    gamer.Exp += scene.Exp;
                    UpdatePlayerStats();

                });
                QueueEvent(() =>
                {
                    pBoxMob.Image = null;
                    PauseForMessage(gamer.Name.ToUpper() + " CONTINUES TO EXPLORE");
                });
            }
            else
            {
                QueueEvent(() =>
                {
                    missSound.Play();
                    pBoxMob.Image = scene.Pic3;
                    PauseForMessage(scene.BadMessage);
                    gamer.Exp += scene.Exp - 4;
                    gamer.CurrentHP -= scene.Dmg;
                    UpdatePlayerStats();

                });
                QueueEvent(() =>
                {
                    pBoxMob.Image = null;
                    PauseForMessage(gamer.Name.ToUpper() + " CONTINUES TO EXPLORE");
                });
            }
        }

        /*
         * combat encouters
         */

        public void StartCombat(Mob enemy)
        {
            if (enemy is Mob.Boss boss)
            {
                BossCombat(boss);
                return;
            }

            currentEnemy = enemy;

            QueueEvent(() =>
            {
                UpdateMob(currentEnemy);
                EnterCombat();
                enemyEncounter.Play();
                PauseForMessage($"A {currentEnemy.Name} attacked!");
            });



        }

        public async Task BossCombat(Mob.Boss boss)
        {
            boss.ResetBoss();

            currentEnemy = boss;

            QueueEvent(async () =>
            {

                EnterCombat();
                UpdateMob(boss);
                PauseForMessage(boss.Intro);

                await BossTurn(boss);
            });


        }
        public async Task BossTurn(Mob.Boss boss)
        {
            if (boss == null || boss.Dead) { return; }

            QueueEvent(async () =>
            {
                //phase 2 here
                if (boss.CurrentHp <= boss.MaxHealth / 2 && boss.Icon != boss.Phase2)
                {
                    boss.Icon = boss.Phase2;
                    reaperphaseSound.PlaySync();
                    PauseForMessage(boss.Phase2Intro);
                    boss.CurrentHp += 15;
                    boss.Damage += 8;
                    UpdateMob(boss);
                    return;
                }

                //specail attk 
                Random rng = gameRng;
                if (rng.Next(4) == 0)
                {
                    boss.SpecialAtk.PlaySync();
                    PauseForMessage("!!! THE " + boss.Name.ToUpper() + " CURSES YOU !!!");

                    await gamer.TakeDmgSpec(boss.SpecialAtkDmg, pBoxHurt);
                    UpdatePlayerStats();

                    return;
                }

                //norm attk
                await gamer.TakeDmg(boss, pBoxHurt);
                UpdatePlayerStats();

            });
        }


        private async void butAttack_Click(object sender, EventArgs e)
        {
            if (currentEnemy == null) return;

            QueueEvent(async () =>
            {
                gamer.Juice = Math.Min(gamer.Juice + 2, 20);

                bool isBoss = currentEnemy is Mob.Boss;
                Mob.Boss bossEnemy = currentEnemy as Mob.Boss;

                if (gamer.BattleClass.Speed > currentEnemy.Speed)
                {
                    if (currentEnemy == null) return;
                    await currentEnemy.TakeDmg(gamer, pBoxHurtMob);
                    if (currentEnemy == null) return;
                    UpdateMob(currentEnemy);

                    if (!currentEnemy.Dead)
                    {
                        if (isBoss)
                        {
                            await BossTurn(bossEnemy);
                        }
                        else
                        {
                            await gamer.TakeDmg(currentEnemy, pBoxHurt);
                        }

                        UpdatePlayerStats();
                    }
                }
                else
                {
                    if (isBoss)
                    {
                        await BossTurn(bossEnemy);
                    }
                    else
                    {
                        await gamer.TakeDmg(currentEnemy, pBoxHurt);
                    }

                    UpdatePlayerStats();


                    if (currentEnemy == null) { return; }
                    await currentEnemy.TakeDmg(gamer, pBoxHurtMob);
                    UpdateMob(currentEnemy);
                }
                if (currentEnemy == null) return;

                if (currentEnemy.Dead)
                {
                    if (currentEnemy is Mob.Boss)
                    {
                        PauseForMessage("!!! " + gamer.Name.ToUpper() + " DEFEATED THE FINAL BOSS CONGRATS !!!");
                        victorySound.Play();
                        gamer.Exp += currentEnemy.XP;
                        UpdatePlayerStats();
                        QueueEvent(() =>
                        {
                            PauseForMessage("!!! THE CASTLE IS SAFE !!!");
                            ExitCombat();
                            Victory_Screen vic = new Victory_Screen(gamer);
                            vic.ShowDialog();
                        });
                        return;
                    }
                    PauseForMessage($"!!! THE {currentEnemy.Name.ToUpper()} WAS SLAIN! +{currentEnemy.XP} XP !!!");
                    victorySound.Play();
                    gamer.Exp += currentEnemy.XP;
                    UpdatePlayerStats();

                    currentEnemy.Reset();
                    currentEnemy = null;

                    ExitCombat();
                }
            });
        }

        private async void butBlock_Click(object sender, EventArgs e)
        {
            if (currentEnemy == null) return;

            QueueEvent(async () =>
            {
                gamer.Juice = Math.Min(gamer.Juice + 7, 20);
                gamer.Blocking = true;

                await gamer.TakeDmg(currentEnemy, pBoxHurt);
                UpdatePlayerStats();
            });
        }

        private async void butRun_Click(object sender, EventArgs e)
        {
            if (currentEnemy == null) return;

            QueueEvent(async () =>
            {
                Random rng = gameRng;
                int roll = rng.Next(101);

                if (gamer.BattleClass.Speed * roll > 140)
                {
                    PauseForMessage($"{gamer.Name.ToUpper()} RAN AWAY!");
                    currentEnemy = null;
                    ExitCombat();
                }
                else
                {
                    PauseForMessage($"{gamer.Name.ToUpper()} FAILED TO ESCAPE!");
                    await gamer.TakeDmg(currentEnemy, pBoxHurt);
                    UpdatePlayerStats();
                }
            });
        }


        /*
         * ui toggle
         */

        public void EnterCombat()
        {
            butWalk.Visible = false;
            butExit.Visible = false;
            butAttack.Visible = true;
            grpBoxMobStats.Visible = true;
            butLevelUp.Visible = false;
            cBoxLevelOpts.Visible = false;
            butBlock.Visible = true;
            butRun.Visible = true;
            butSave.Visible = false;

        }

        public void ExitCombat()
        {
            butWalk.Visible = true;
            butExit.Visible = true;
            butAttack.Visible = false;
            grpBoxMobStats.Visible = false;
            butLevelUp.Visible = true;
            cBoxLevelOpts.Visible = true;
            butBlock.Visible = false;
            butRun.Visible = false;
            butHeal.Visible = true;
            butSave.Visible = true;
            UpdateMob(empty);

            currentEnemy = null;
            readyToExplore = true;
        }

        /*
         * level up
         */

        private void butLevelUp_Click(object sender, EventArgs e)
        {
            lvlSound.Play();
            if (gamer.Exp >= 10 && cBoxLevelOpts.SelectedIndex != -1)
            {
                switch (cBoxLevelOpts.SelectedIndex)
                {
                    case 0:
                        gamer.BattleClass.HpUp(); gamer.CurrentHP += 3;
                        break;
                    case 1:
                        gamer.BattleClass.DmgUp();
                        break;
                    case 2:
                        gamer.BattleClass.SpdUp();
                        break;
                }

                gamer.Level += 1;
                gamer.Exp -= 10;
                UpdatePlayerStats();
            }
            else
            {
                AddMessage("Not enough exp (10 req)");
            }
        }


        private void butExit_Click(object sender, EventArgs e)
        {
            deathSound.Stop();
            this.Close();
        }

        //game messages for combat log

        public static class GameMessages
        {
            public static Action<string> Output;
            public static void Send(string message) => Output?.Invoke(message);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            string filePath = "save.txt";

            using (StreamWriter saveWriter = new StreamWriter(filePath))
            {
                saveWriter.WriteLine(gamer);
            }
            this.Close();
        }
    }
}