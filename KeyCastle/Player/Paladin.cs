using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCastle.Player
{
    public class Paladin : Hero
    {
        Random rand = new Random();
        public Paladin()
        {
            CharacterClass = "Paladin";
            MaxDamage = 35;
            MinDamage = 15;
        }

    }



//    public string CharacterClass { get; set; }
//    public string HeroName { get; set; }
//    public int Damage { get; set; }
//    public int Fight { get; set; }

}
