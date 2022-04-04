using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCastle.Dialoge
{
    internal class Script
    {
        public static Dictionary<string, string[]> Messages = new Dictionary<string, string[]>
        {

            {"Select class", new string[]

            { "Player, please select your class",
              "Would you like to be a Wizard?",
              "Or are you wanting to be a Paladin?"} },

            {"Story start", new string[]
            {

                "You're coming back from a long journey of fighting monsters and doing cool stuff...",
                "You spot a castle from afar and go closer to get a better look. It looks long",
                " abandoned and will be a good place to stop and rest for the night",
                "",
                "As you get closer though you notice a small light coming from inside the front",
                " door which was cracked open. You step into the castle...",
                

            } },

            {"Entryway start", new string[]
            {
                "You walk in and you are in a hallway, unusual for such a large castle",
                "You see a man standing in a window to your right",
                "\"Hello traveler. Welcome to Key castle",
                "It is said there is treasure behind one of these doors",
                "I have not been able to make it myself, i am not fighter or mage",
                "but, one day when i am programmed to i will give you health potions",
                "in exchange for some of the gold you find if you make it through\"",

            } },

            {"Entryway Loop", new string[]
{
                 "You look at the hallway, there are doors to the left and right",
                   "at the end of the hallway was a large intricate door",
                    "a faint golden glow was peaking through the cracks...",
                            
            }
            },
            {"Dragon script", new string[]
            {
                "As you walk into the room a fireball flies past your face",
                "",
                "You dodge just in time.... ",
                "",
                "Towering before you is a large Dragon!",
                "",
                "I have been here for a thousand years puny human",
                "leave at once or i will deal with you",
                "like i have dealt with the others",
                "",
                "You notice an unsettling large pile of bones, but also there is a key around the dragons neck",
                "",
                "Get ready to start a fight with the Dragon"

            } },

            {"Skeleton script", new string[]
            {
                @"You walk into a dim room. Stone walls surrounds you. The room looks empty.",
                "You see a skeleton sitting in the corner, poor soul",
                "You go to leave the room, but before you make it to the door you hear shuffling behind you",
                "as you turn and see the skeleton just before it leaps to attack",
                "",
                "Get ready to fight a skeleton!", } },
            {"Skeleton dead", new string[]
            {
            "The skeleton crumbles to the floor turning into nothing more than ashes.",
            "You go closer to inspect and notice a piece of paper within the pile,",
            "It is torn you can only make out the words-  \"It's a tr..\" ",
            "You discard the piece of paper and walk out of the room.", }},
            {"Player dead", new string[]
            {
                "You lay on the ground, a pile of blood slowly surrounds you. Could this be it?\n" +
                " Are you really going to die here?",
                "",
                "",
                "the answer is yes. yes you are. GAME OVER."
            } },

            {"Ending script", new string[]
            {
                "The door opens to reveal a large room full of gold! You will forever be rich!",
                "",
                "You drop down in front of a treasure chest full of gold and starting grabbing as much as you can",
                "",
                "You were so excited by the gold you realized too late the door being shut behind you...",
                "",
                "As you stand up in panick You hear a clicking sound and feel the ground beneath you dissapear",
                "",
                "You fall into the abyss below",
                "",
                "to be continued...",
            } },
            {"Cyclops script", new string[]
            {
                "You slowly open the door, scanning the room for any signs of trouble",
                "Just as you suspected a large one eyed monster yells 'itklfkakdhntraphnjhfuejnf",
                "You pull your weapon",
                "",
                "Get ready to fight a Cyclops!",

            } }


        };
    }
}
