using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Banquet
{
    class Introduction
    {   //Color Selection variables
        public static string colorstring;
        public static int gameColor;

        //Ready to play variables
        static string ready;
        static char readychar;

        //Players are given one of four options, and then their choice is converted to an int.
        //A switch statement will assign a color to the game depending on their choice.
        public static int ColorSelection()
        {
            Console.WriteLine("Before we begin, you can choose to change the color of the console.");
            Console.WriteLine("Your options are:\n1. Standard white on black");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("2. Blue on white");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("3. Red on white");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Or");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("4. Black on white");
            Console.WriteLine("Only input the number of your preferred choice: 1 - 4.");
            colorstring = Console.ReadLine();

            if (string.IsNullOrEmpty(colorstring))
            {
                colorstring = "1";
            }

            gameColor = int.Parse(colorstring);
            return gameColor;
        }

        public static void Rules()
        {
            Console.WriteLine("In this game, you will occasionally be prompted to interact with the world around you as you go about your day.");
            Console.WriteLine("There will be line breaks to help break up the text.\nUnless you are prompted to enter any information, just press enter to proceed the text.");
            Console.ReadLine();
            Console.WriteLine("Characters you encounter will have their text appear-");
            Console.WriteLine("Narrator: Like this. With their names appearing before the text as if they were in a play.");
            Console.WriteLine("Otherwise, it's just me - the Narrator - describing the scene to you.");
            Console.ReadLine();
            Console.WriteLine("One final note. The things you do can increase your intelligence, kindness or charm.");
            Console.WriteLine("Keep that in mind when you come across people.\nWho knows how those stats might affect your experience at the end of the night.");
            Console.ReadLine();
            Console.WriteLine("With that, the game can begin. Assuming you're ready.");
            Console.WriteLine("Are you ready?");
            Console.Write("Y/N ");

            ready = Console.ReadLine();
            if (string.IsNullOrEmpty(ready))
            {
                ready = "n";
            }
            ready = ready.ToUpper();
            ready = ready.Trim();
            readychar = ready[0];

            if (readychar != 'Y')
            {
                Console.WriteLine("You aren't ready? I see.\nIn that case, please come back whenever you are.");
                Environment.Exit(0);
            }
        }

        public static string Welcome()
        {
            Console.WriteLine("You are a lowly lord who has been summoned by His Royal Highness Einhart Magis.");
            Console.WriteLine("You are not as renowned as the Ultires of Jade Port or the Welshires of Yorkshire\n- to say that of yourself would be an insult to them -\nbut you are well enough known to have gotten an invitation to a banquet!");
            Console.ReadLine();
            Console.WriteLine("The banquet is tonight. A whole day is ahead of you to do with as you please.\nI wonder, how will you spend it?");
            Console.WriteLine("Now, onwards, Lord...\nWhat is your name exactly, milord?\nIs your name:");
            Console.ReadLine();
            Console.WriteLine("1. Donovan\n2. Alistair\n3.Rodrick\nOr\n4. Will you choose your own name?\nJust as last time, just the number that matches your answer.");
            Player.nameSelection = Console.ReadLine();

            switch (Player.nameSelection)
            {
                case "1":
                    Player.playerName = "Donovan";
                    Console.ReadLine();
                    break;
                case "2":
                    Player.playerName = "Alistair";
                    Console.ReadLine();
                    break;
                case "3":
                    Player.playerName = "Rodrick";
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("In that case, please enter your name.");
                    Player.playerName = Console.ReadLine();
                    Console.ReadLine();

                        if(string.IsNullOrEmpty(Player.playerName))
                        {
                        Player.playerName = "Zain";
                        }
                    break;
                default:
                    Player.playerName = "Zain";
                    break;
            }

            return Player.playerName;
        }
    }
}
