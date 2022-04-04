using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KeyCastle.Monsters
{
    public class Dragon : Monster
    {
        Random rand = new Random();
        public Dragon()
        {
            GoldHeld = 1000; 
            MonsterName = "Dragon";

        }
        public static bool HasKey { get; set; } = true;
        

        
        
        



    }
}
