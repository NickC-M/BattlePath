using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChapman_Miller_Final_Project
{
    public class Room
    {
        public string Name;
        public bool IsExit;
        public Mob Enemy;
        public Encounter Encounter;

        public Room(string name, bool isExit, Mob enemy, Encounter encounter)
        {
            Name = name;
            IsExit = isExit;
            Enemy = enemy;
            Encounter = encounter;
        }
    }
}
