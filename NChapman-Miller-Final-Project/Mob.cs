using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static NChapman_Miller_Final_Project.frmGame;

namespace NChapman_Miller_Final_Project
{
    public class Mob
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHp { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int Accuracy { get; set; }
       public Image Icon { get; set; }
        public bool Dead { get; set; }
        public int ID { get; set; }
        public int XP { get; set; }

        private SoundPlayer missSound = new SoundPlayer(Properties.Resources.Miss);

        public Mob(string name, int maxHealth,int currentHP, int damage, int speed, int accuracy, Image icon, int iD, int xP)
        {
            currentHP = maxHealth;
            Name = name;
            MaxHealth = maxHealth;
            Damage = damage;
            Speed = speed;
            Accuracy = accuracy;
            Icon = icon;
            CurrentHp = currentHP;
            ID = iD;
            XP = xP;
        }
        public Mob() { }

        public async Task TakeDmg(Player gamer, PictureBox hurt)
        {
            Random rng = new Random();
            int accRng = rng.Next(101);
            if (accRng > gamer.BattleClass.Accuracy)
            {
             
                GameMessages.Send("!!! " + gamer.Name.ToUpper() + " MISSED THEIR ATTACK !!!");
                await Task.Delay(800);
                missSound.Play();
                
                return;
            }
          
            hurt.Visible = true;
            CurrentHp -= gamer.BattleClass.Damage;
            GameMessages.Send("!!! "+gamer.Name.ToUpper() + " ATTACKED FOR " + gamer.BattleClass.Damage + "! THE "+Name.ToUpper() + " HAS "+ CurrentHp + " HEALTH POINTS LEFT");
            gamer.BattleClass.AtkSd.Play();
            await Task.Delay(1000);
            hurt.Visible = false;
            if (CurrentHp < 0)
            {
                CurrentHp = 0;
                Dead = true;
            }
         
        }
        public void Reset()
        {
            CurrentHp = MaxHealth;
            Dead = false;
        }

        public void ResetBoss()
        {
            CurrentHp = MaxHealth;
            Damage = Damage; 
            Icon = Icon;
            Dead = false;
        }
        public class Boss : Mob
        {
            public Image Phase2 { get; set; }
            public string Intro {  get; set; }
            public string Phase2Intro { get; set; }
            public SoundPlayer SpecialAtk { get; set; }
            public int SpecialAtkDmg { get; set; }

            public Boss(string name, int maxHealth, int damage, int speed, int accuracy, Image icon, int iD, int xp, Image phase2, string intro, string phase2Intro, SoundPlayer specialAtk, int specialAtkDmg) : base(name, maxHealth, maxHealth, damage, speed, accuracy, icon, iD, xp)
            {
                Phase2 = phase2;
                Intro = intro;
                Phase2Intro = phase2Intro;
                SpecialAtk = specialAtk;
                SpecialAtkDmg = specialAtkDmg;
            }
        }

    }
}
