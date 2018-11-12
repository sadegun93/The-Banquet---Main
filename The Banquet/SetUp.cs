using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*The Banquet
 * Created by: Stephen Adegun
 * Created 09/18/2018 @ 8:05 PM
 * Objective for 09/18/2018 - Create Introduction Class
 * Progress Made 09/18/2018 - Created Introduction Class & Player Class
 * Objective for 09/30/2018 - Create Tier1 Class
 * Progress Made 09/30/2018 - Created Tier1 Class; devised way for scenarios to play out once written
 * Objective for 10/07/2018 - Increment stats for Tier 1
 * Progress Made 10/07/2018 - Finish Tier 1 Scenarios 1, 2, and 3, and created all accompanying variables
 * Objective for 11/12/2018 - Look at the code and rework it to reflect what I've learned since last workday.
 * Progress Made 11/12/2018 - Code optimized and revised with new knowledge
 */

namespace The_Banquet
{
    public static class SetUp
    {   //Color Selection variables
        static string colorstring;
        static int gameColor;
        static bool tryGameColor;

        //To validate the player's choice in each tier
        static bool ValidateChoice;
        public static bool GetValidateChoice
        {
            get
            {
                return ValidateChoice;
            }
        }
        public static bool SetValidateChoice
        {
            set
            {
                ValidateChoice = value;
            }
        }

        //Ready to play variables
        static string ready;
        static char readychar;

        //String Array to save the choices players make for each of the tiers rather than making 6 different variables
        static string[] tierChoice = new string[6];
        public static string[] GetTierChoice
        {
            get
            {
                return tierChoice;
            }
        
            set
            {
                tierChoice = value;
            }
        }

        //Int Array to save the choices players make for each of the tiers rather than making 6 different variables
        static int[] tierChoiceNum = new int[6];
        public static int[] GetTierChoiceNum
        {
            get
            {
                return tierChoiceNum;
            }
        }

        //Int Array to save the outcomes of each tier, assuming they will be referenced later
        //These ints will be used to keep track of what the player did in each tier so they can be referenced later.
        static int[] TierOutcome = new int[6];
        public static int[] GetTierOutcome
        {
            get
            {
                return TierOutcome;
            }

            set
            {
                TierOutcome = value;
            }
        }

        //Players are given one of four options, and then their choice is converted to an int.
        //A switch statement will assign a color to the game depending on their choice.
        public static void ColorSelection()
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

            while (tryGameColor != true || string.IsNullOrEmpty(colorstring) || gameColor > 4)
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

            switch (gameColor)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
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
            Console.WriteLine("1. Donovan\n2. Alistair\n3.Rodrick\n4. Zain\nOr\n5. Will you choose your own name?\nJust as last time, just the number that matches your answer.");
            Player.SetNameSelection = Console.ReadLine();
            while (String.IsNullOrEmpty(Player.GetNameSelection))
            {
                Console.WriteLine("You didn't enter a name. You very well can't go about without a name! What is your name, milord?");
                Console.WriteLine("1. Donovan\n2. Alistair\n3.Rodrick\n4. Zain\nOr\n5. Will you choose your own name?\nJust as last time, just the number that matches your answer.");
                Player.SetNameSelection = Console.ReadLine();
            }

            Player.SetValidateName = int.TryParse(Player.GetNameSelection, out Player.nameSelectionNum);

            while(Player.GetValidateName == false || Player.nameSelectionNum > 5)
            {
                Console.WriteLine("Your input was invalid. Please choose one of your five options.");
                Player.SetNameSelection = Console.ReadLine();

                while (String.IsNullOrEmpty(Player.GetNameSelection))
                {
                    Console.WriteLine("You didn't enter a name. You very well can't go about without a name! What is your name, milord?");
                    Console.WriteLine("1. Donovan\n2. Alistair\n3.Rodrick\n4. Zain\nOr\n5. Will you choose your own name?\nJust as last time, just the number that matches your answer.");
                    Player.SetNameSelection = Console.ReadLine();
                }

                Player.SetValidateName = int.TryParse(Player.GetNameSelection, out Player.nameSelectionNum);
            }

            switch (Player.nameSelectionNum)
            {
                case 1:
                    Player.SetPlayerName = "Donovan";
                    Console.ReadLine();
                    break;
                case 2:
                    Player.SetPlayerName = "Alistair";
                    Console.ReadLine();
                    break;
                case 3:
                    Player.SetPlayerName = "Rodrick";
                    Console.ReadLine();
                    break;
                case 4:
                    Player.SetPlayerName = "Zain";
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("In that case, please enter your name.");
                    Player.SetPlayerName = Console.ReadLine();

                    while (String.IsNullOrEmpty(Player.GetPlayerName))
                    {
                        Console.WriteLine("You didn't enter a name. You very well can't go about without a name! What is your name, milord?");
                        Player.SetPlayerName = Console.ReadLine();
                    }
                    break;
                default:
                    Player.SetPlayerName = "Zain";
                    break;
            }

            return Player.GetPlayerName;
        }

        public static void QuitGame()
        {
            Console.WriteLine("I see. That's a shame.\nIn that case, please come back whenever you are ready to.");
            Environment.Exit(0);
        }
    }
}
