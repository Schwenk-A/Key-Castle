using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCastle.Dialoge
{
    internal class MessagePrinter
    {
        public static void MessageToScreen (string[] strings)
        {
            foreach(var msg in strings)
            {
                Console.WriteLine(msg);
            }
        }

      
    }
}
