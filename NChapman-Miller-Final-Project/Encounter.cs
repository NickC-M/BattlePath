using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChapman_Miller_Final_Project
{
    public class Encounter
    {
        public string Name { get; set; }
        public string FirstMessage { get; set; }
        public string LastMessage { get; set; }
        public Image Pic { get; set; }
        public Image Pic2 { get; set; }
        public Image Pic3 { get; set; }
        public int Exp {  get; set; }
        public int Dmg { get; set; }
        public string BadMessage { get; set; }
        public Encounter(string name, string firstMessage,string lastMessage,string badMessage, Image pic, Image pic2,Image pic3,  int exp)
        {
            Name = name;
            FirstMessage = firstMessage;
            LastMessage = lastMessage;
            BadMessage = badMessage;
            Pic = pic;
            Pic2 = pic2;
            Pic3 = pic3;
            Exp = exp;
        }
        public Encounter(string name, string firstMessage, Image pic,  int exp, int dmg)
        {
            Name = name;
            FirstMessage = firstMessage;
            Pic = pic;
            Exp = exp;
            Dmg = dmg;
        }
        public Encounter(string name, string firstMessage, Image pic, Image pic2, int exp)
        {
            Name = name;
            FirstMessage = firstMessage;
            Pic = pic;
            Pic2 = pic2;
            Exp = exp;
           
        }
    }
}
