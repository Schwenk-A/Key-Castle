using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCastle.Monsters
{
    public abstract class Monster
    {
        public Monster()
        {

        }
        //____________________________________________ Already set
        public double MaxHealth { get; set; } = 100;
        public double TotalLife { get; set; } = 100;
        public bool IsDead { get; set; } = false;
        public int MaxDamage { get; set; } = 10;
        public double GoldHeld { get; set; } = 10;

        //____________________________________________To be set
        public string MonsterName { get; set; } 
        public double GoldDropped { get; set; }
        public int MinDamage { get; set; } = 1;
       


    }
}
