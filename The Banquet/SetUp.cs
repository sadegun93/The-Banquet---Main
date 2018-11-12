using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Banquet
{
    public static class SetUp
    {   //Color Selection variables
        public static string colorstring;
        public static int gameColor;
        public static bool tryGameColor;

        //Ready to play variables
        static string ready;
        static char readychar;

        //String Array to save the choices players make for each of the tiers rather than making 6 different variables
        public static string[] tierChoice = new string[6];
        //Int Array to save the choices players make for each of the tiers rather than making 6 different variables
        public static int[] tierChoiceNum = new int[6];
        //Int Array to save the outcomes of each tier, assuming they will be referenced later
        //These ints will be used to keep track of what the player did in each tier so they can be referenced later.
        public static int[] TierOutcome = new int[6];

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
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            colorstring = Console.ReadLine();
            tryGameColor = int.TryParse(colorstring, out gameColor);

            while(tryGameColor != true || string.IsNullOrEmpty(colorstring) || gameColor > 4)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Your choice of color was not valid. Please choose:");
                Console.WriteLine("Standard white on black");
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
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                colorstring = Console.ReadLine();
                tryGameColor = int.TryParse(colorstring, out gameColor);
            }
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
            while(string.IsNullOrEmpty(ready))
            {
                Console.WriteLine("You didn't input anything. We can't have that. Are you ready to play? Y/N");
                ready = Console.ReadLine();
            }
            ready = ready.ToUpper();
            ready = ready.Trim();
            readychar = ready[0];

            while (ready != "N" && ready != "Y")
            {
                Console.WriteLine("You didn't say that you were ready. The game can't start until you do. Are you ready?\nY/N");
                ready = Console.ReadLine();
                ready = ready.ToUpper();
                ready = ready.Trim();
                while (string.IsNullOrEmpty(ready))
                {
                    Console.WriteLine("You didn't input anything. We can't have that. Are you ready to play? Y/N");
                    ready = Console.ReadLine();
                }
                ready = ready.ToUpper();
                ready = ready.Trim();
                readychar = ready[0];
            }

            if (readychar != 'Y')
            {
                QuitGame();
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

        public static void QuitGame()
        {
            Console.WriteLine("I see. That's a shame.\nIn that case, please come back whenever you are ready to.");
            Environment.Exit(0);
        }
    }
}
