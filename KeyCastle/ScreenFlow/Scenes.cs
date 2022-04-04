using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyCastle.Dialoge;
using KeyCastle.Player;
using KeyCastle.Monsters;

namespace KeyCastle.ScreenFlow
{
    internal class Scenes
    {


        public static void TitleMenu() //Prints the Title screen 
        {
            ScreenPrinter.PictureToScreen(Screens.Glossary["Castle"]);
            Console.ReadKey();
            Console.Clear();
        }

        public static void StoryStart(string player)
        {
            MessagePrinter.MessageToScreen(Script.Messages["Story start"]);
            Console.WriteLine($"press any Key to continue {player}");
            Console.ReadLine();
            Console.Clear();
        } //This gives the user the starting diologe.

        public static void EntrywayStart(Hero player)
        {
            ScreenPrinter.PictureToScreen(Screens.Glossary["Hallway"]);
            MessagePrinter.MessageToScreen(Script.Messages["Entryway start"]);
            Console.ReadKey();
            Entryway(player);
        }

        public static void Entryway(Hero player)
        {

            var locationoptions = new string[]
            { "First Left Room","Second Left Room","First Right Room", "Second Right Room", "The Door at the end of the hall"};

            var roomChoice = GetInput(Script.Messages["Entryway Loop"], locationoptions);
            switch (roomChoice)
            {
                case var choice when choice == locationoptions[0]:
                    Fighting.PlayerVsMonster(player, new Cyclops());
                    break;                
                case var choice when choice == locationoptions[1]:
                    Console.WriteLine("There is nothing in this room...best not to go inside");
                    Console.ReadLine();
                    Entryway(player);
                    break;                
                case var choice when choice == locationoptions[2]:
                    Fighting.PlayerVsMonster(player, new Skeleton());
                    break;                
                case var choice when choice == locationoptions[3]:
                    Fighting.PlayerVsMonster(player, new Dragon());
                    break;
                case var choice when choice == locationoptions[4]:
                    LockedDoor(player);
                    break;
            }


        }
        public static string GetInput(string[] messages,string[] options)
        {
            var selectionMade = false;
            var currentIndex = 0;

            //while selection has not been made, continue printing screen
            while (!selectionMade)
            {
                Console.Clear();
                ScreenPrinter.PictureToScreen(messages);
                Console.WriteLine("There are two doors to the left, two to the right");
                Console.WriteLine("Which way would you like to go?");
                //Print message options
                PrintMessageOptions( currentIndex, options);

                var userchoice = Console.ReadKey().Key;
                switch (userchoice)
                {
                    case ConsoleKey.Enter:
                        selectionMade = true;               
                        break;
                    case ConsoleKey.UpArrow:
                        // up arrow means go down an index

                        // if our current index is 0, go to the last index in options - else go up to next option (down an index)
                        currentIndex = currentIndex == 0 ? options.Length - 1 : currentIndex - 1;

                        /*
                         
                        0 - Room 1  <--     If you're at 0 and you click up, you need to go to max.
                        1 - Room 2
                        2 - Room 3 <--      If you're at max and you click down, you need to go to 0
                         
                         */

                        break;
                    case ConsoleKey.DownArrow:
                        // if you go down, you go up
                        currentIndex = currentIndex == options.Length - 1 ? 0 : currentIndex + 1;  
                        // we use option.Length - 1 because the number of objects in our array is not the same as the index of the last object in the array
                        break;

                }
            }

            //when we get input, return string for which location
            return options[currentIndex];
        }

            //take our string array of options apply arrows to the selected index and print all 
        private static void PrintMessageOptions(int currentIndex, string[] options)
        {

            for (int i = 0; i < options.Length; i++)
            {
                // write the option to the console - if it's the selected index, add arrow " <--"
                Console.WriteLine(i == currentIndex ? $"{options[i]} <---" : options[i]);
            }

        }




        public static void LockedDoor(Hero player)
        {
            Console.Clear();
            ScreenPrinter.PictureToScreen(Screens.Glossary["Vanishing Door"]);
            Console.WriteLine("You come up to the door. It is intricate and has a sort of pull on you,");
            Console.WriteLine("Do you wish you open it? Yes or no?");
            var UserDoorChoice = Console.ReadLine().ToLower();
            if (UserDoorChoice == "yes" && player.HasKey)
            {
                Console.Clear();
                ScreenPrinter.PictureToScreen(Screens.Glossary["Treasure"]);
                MessagePrinter.MessageToScreen(Script.Messages["Ending script"]);
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);

            }
            else if (UserDoorChoice == "yes" && !player.HasKey)
            {
                Console.WriteLine("You must find the key to open this door");
                Entryway(player);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You must find the key to open this door");
                Entryway(player);
            }
        }

        public static void DeadScene()
        {
            ScreenPrinter.PictureToScreen(Screens.Glossary["Dead"]);
            MessagePrinter.MessageToScreen(Script.Messages["Player dead"]);
            Console.ReadKey();

        }

        public static string[] PadAlltoCenter(string[] strings)
        {
            return strings.ToList().Select(s => PadToCenter(s)).ToArray();
        }
        public static string PadToCenter(string str)
        {
            var leftpadding = (Console.WindowWidth / 2) - (str.Length / 2);
            return str.PadLeft(leftpadding);
        }
    }
}
