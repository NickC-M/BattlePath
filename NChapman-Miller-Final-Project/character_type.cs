using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace NChapman_Miller_Final_Project
{
    public class character_type
    {
      public string Name { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int MaxHealth { get; set; }
        public int Accuracy { get; set; }
        public Image Icon;
        public SoundPlayer AtkSd;


        public character_type(string name, string description, int damage, int defense, int speed, int maxhealth, int accuracy, Image icon, SoundPlayer atkSd)
        {
            Name = name;
            Description = description; 
            Damage = damage;
            Defense = defense;
            Speed = speed; 
            MaxHealth = maxhealth;
            Accuracy = accuracy;
            Icon = icon;
            AtkSd = atkSd;
        }

      

        public void DmgUp()
        {
            Damage +=1;
         
        }
        public void DefUp()
        {
            Defense += 1;

        }
        public void SpdUp()
        {
            Speed += 1;
           
        }
        public void HpUp()
        {
            MaxHealth += 3;
        
        }
    }
}
