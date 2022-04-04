using System;
using System.Collections.Generic;
using KeyCastle.Dialoge;
using KeyCastle.Player;
using KeyCastle.ScreenFlow;




namespace KeyCastle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 80;
            //________________________________________________
            Scenes.TitleMenu();
            var player = SelectedClass();
            player.HeroName = CollectName();
            Scenes.StoryStart(player.HeroName);
            Scenes.EntrywayStart(player);
            Console.ReadKey();

           


        }

        public static Hero SelectedClass()
        {
            

                MessagePrinter.MessageToScreen(Script.Messages["Select class"]);
               var userClassChoice = Console.ReadLine().ToLower();
           
            if (userClassChoice == "paladin")
            {
                Console.Clear();
                Console.WriteLine("You have selected the brave Paladin. Sharpen your sword for the adventure ahead.");
                return new Paladin();
            }
            else if (userClassChoice == "wizard")
            {
                Console.Clear();
                Console.WriteLine("Brace yourself Wizard for the adventure ahead.");
                return new Wizard();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You gave an incorrect answer bro, try again");
                return SelectedClass();
            }

        } //returns a new player of a specific type
  
        public static string CollectName()
        {
            Console.WriteLine("Please enter your name brave hero");
            var heroName=Console.ReadLine();
            Console.Clear();
            return heroName;
        } //Collects the user's name of choice.









    }
}
