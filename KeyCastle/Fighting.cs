using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyCastle.Player;
using KeyCastle.Monsters;
using KeyCastle.Dialoge;
using System.Threading;
using KeyCastle.ScreenFlow;

namespace KeyCastle
{
    public static class Fighting
    {

        public static void PlayerVsMonster(Hero player, Monster monster)
        {
            Console.Clear();
            if (monster.GetType() == typeof(Dragon))
            {
                ScreenPrinter.PictureToScreen(Screens.Glossary["Dragon"]);
                MessagePrinter.MessageToScreen(Script.Messages["Dragon script"]);
                Console.WriteLine("Press anything to continue");
                Console.ReadKey();
                Console.Clear();
                ScreenPrinter.PictureToScreen(Screens.Glossary["Dragon"]);
            }
            if (monster.GetType() == typeof(Cyclops))
            {
                ScreenPrinter.PictureToScreen(Screens.Glossary["Cyclops"]);
                MessagePrinter.MessageToScreen(Script.Messages["Cyclops script"]);
                Console.ReadKey();
                Console.Clear();
                ScreenPrinter.PictureToScreen(Screens.Glossary["Cyclops"]);
            }
            if (monster.GetType() == typeof(Skeleton))
            {
                ScreenPrinter.PictureToScreen(Screens.Glossary["Skeleton"]);
                MessagePrinter.MessageToScreen(Script.Messages["Skeleton script"]);
                Console.ReadKey();
                Console.Clear();
                ScreenPrinter.PictureToScreen(Screens.Glossary["Skeleton"]);
            }

                Random rand = new Random();

            //while both are alive, keep fighting
            while (player.TotalLife >0 && monster.TotalLife > 0)
            {
                var playerDamage = rand.Next(player.MinDamage, player.MaxDamage);
                monster.TotalLife -= playerDamage ; //dragons total life after being attacked
                Console.WriteLine("");
                Console.WriteLine($"You have hit the {monster.MonsterName} with {playerDamage} damage!");

                Console.WriteLine(monster.TotalLife <= 0 ? "You killed it" : $"It's total life is {monster.TotalLife}");
                Thread.Sleep(1200);
                Console.WriteLine("____________________________________________________________");

                if (monster.TotalLife <= 0)
                {
                    Console.WriteLine($"You won and killed the {monster.MonsterName}!");

                    if ( monster.GetType() == typeof(Dragon))
                    {
                        Console.WriteLine("The dragon has dropped a key... Wonder where this goes.");
                        Console.WriteLine("press anything to go back to the start.");
                        Console.ReadKey();

                        player.HasKey = true;
                    }
                    else if (monster.GetType()== typeof(Cyclops))
                    {
                        player.GoldHeld += monster.GoldDropped;
                        Console.WriteLine($"Player now has {player.GoldHeld} Gold.");
                        Console.ReadKey();
                    }
                    else if(monster.GetType() == typeof(Skeleton))
                    {
                        MessagePrinter.MessageToScreen(Script.Messages["Skeleton dead"]);
                        player.GoldHeld += monster.GoldDropped;
                        Console.WriteLine($"Player now has {player.GoldHeld} Gold.");
                        Console.ReadKey();

                    }
                    Scenes.Entryway(player);
                }

                var dragonDamage = rand.Next(monster.MinDamage, monster.MaxDamage);
                player.TotalLife -= dragonDamage;
                Console.WriteLine("");
                Console.WriteLine($"{monster.MonsterName} has hit you with {dragonDamage} damage!");

                Console.WriteLine(player.TotalLife <= 0 ? "You died" : $"Your total life is {player.TotalLife}");
                Console.WriteLine("____________________________________________________________");
                Thread.Sleep(1200);

                if (player.TotalLife <= 0)
                {
                    Scenes.DeadScene();
                }
            }
            if (player.TotalLife >= 0)
            {
                Scenes.Entryway(player);
            }



        }



    }
}
