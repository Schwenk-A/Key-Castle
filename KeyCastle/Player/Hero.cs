using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCastle.Player
{
     public abstract class Hero
    {
        public Hero()
        {

        }

 //________________________________________________________________Already set       
        public double ExperiencePoints { get; set; } = 100;
        public double MaxHealth { get; set; } = 100;
        public double TotalLife { get; set; } = 100;
        public double GoldHeld { get; set; } = 10;
        public int MaxDamage { get; set; } = 35;
        public int MinDamage { get; set; } = 1;
        public string Location { get; set; }

   //______________________________________________________________ To be set
        public string CharacterClass { get; set; }
        public string HeroName { get; set; }
        public bool HasKey { get; set; }





    }
}
