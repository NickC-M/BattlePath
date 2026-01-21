using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using static NChapman_Miller_Final_Project.frmGame;
namespace NChapman_Miller_Final_Project
{
    public class Player
    {
        public string Name { get; set; }
        public character_type BattleClass { get; set; }
        public int CurrentHP { get; set; } 
        public int Exp { get; set; }
        public int Level { get; set; }
        public bool Dead { get; set; }
        public int Juice { get; set; }
        public bool Blocking { get; set; }

        private SoundPlayer missSound = new SoundPlayer(Properties.Resources.Miss);
        private SoundPlayer blockSound = new SoundPlayer(Properties.Resources.block);
        private SoundPlayer hurtSound = new SoundPlayer(Properties.Resources.hurt);

        public Player(string name, character_type battleClass, int currentHP, int exp, int level)
        {
            currentHP = battleClass.MaxHealth;
            Name = name;
            BattleClass = battleClass;
            CurrentHP = currentHP;
            Exp = exp;
            Level = level;
            
       
          
        }
        public Player(int currentHP, string name, character_type battleClass, int exp, int level)
        {
            
            Name = name;
            BattleClass = battleClass;
            CurrentHP = currentHP;
            Exp = exp;
            Level = level;



        }
        public Player()
        {

        }
        public async Task TakeDmg(Mob enemy, PictureBox hurt)
        {
            if (enemy == null) return;
            Random rng = new Random();
            int accRng = rng.Next(101);
            if(accRng > enemy.Accuracy)
            {
                
                GameMessages.Send("!!! " + enemy.Name.ToUpper() + " MISSED THEIR ATTACK !!!");
                await Task.Delay(700);
                missSound.Play();
               
                return;
            }
            if (Blocking && BattleClass.Defense > enemy.Damage)
            {
              
                GameMessages.Send("!!! " + enemy.Name.ToUpper() + "'s ATTACK WAS BLOCKED !!!");
                await Task.Delay(1000);
                blockSound.Play();
                Blocking = false;
              
                return;
            }else if (Blocking)
            {
                int dmgOver = enemy.Damage- BattleClass.Defense;
               
                hurt.Visible = true;

                GameMessages.Send($"!!! {Name.ToUpper()} BLOCKED {BattleClass.Defense} DAMAGE, BUT TAKES {dmgOver} DAMAGE FROM THE {enemy.Name.ToUpper()}'S REMAINING ATTACK !!!");
                await Task.Delay(800);
                blockSound.Play();
                await Task.Delay(600);
                hurtSound.Play();
                
                hurt.Visible = false;
                Blocking = false;
                CurrentHP -= dmgOver;
                return;
            }
            
           
            hurt.Visible = true;
            CurrentHP = CurrentHP - enemy.Damage;
            GameMessages.Send("!!! "+enemy.Name.ToUpper() + " ATTACKED FOR "+ enemy.Damage + " DAMAGE! LEAVING " +Name.ToUpper() +" WITH " + CurrentHP + " HEALTH POINTS !!!");
            await Task.Delay(300);
            hurtSound.Play();
            await Task.Delay(1000);
            hurt.Visible = false;
            if (CurrentHP < 0)
            {
                CurrentHP = 0;
                Dead = true;
            }
        }
        public void Heal()
        {
            int temp = CurrentHP;
            int temp2 = Juice;
            CurrentHP += (2*Juice);
            if(CurrentHP > BattleClass.MaxHealth)
            {
                CurrentHP = BattleClass.MaxHealth;
            }
            int amtHealed = CurrentHP - temp;
            GameMessages.Send("You have consumed " + temp2 + " juice to heal " + amtHealed + " health points");
            Juice = 0;
            
        } 
        
        public Player ExpUp(Player user)
        {
            user.Exp++;
            return user;
        }

        public async Task TakeDmgSpec(int dmg, PictureBox hurt)
        {
            hurt.Visible = true;
            CurrentHP -= dmg;
            if (CurrentHP < 0)
            {
                CurrentHP = 0;
            }
            GameMessages.Send("!!! " + Name.ToUpper() + " TOOK " + dmg + " DAMAGE  LEAVING THEM WITH "+CurrentHP +" HEALTH !!!");
            await Task.Delay(800);
            hurt.Visible=false;
        }


        public override string ToString()
        {

            return $"{CurrentHP},{Name},{BattleClass.Name},{BattleClass.Damage},{BattleClass.MaxHealth},{BattleClass.Speed},{Exp},{Level}";
        }
    }
}
