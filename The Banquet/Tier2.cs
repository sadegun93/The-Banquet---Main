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
    public static class Tier2
    {

        //keeps track of what drink the player chooses to take.
        static string drinkString;
        static int drink;
        public static int GetDrink
        {
            get
            {
                return drink;
            }
        }

        public static int Tier2Introduction()
        {

            Console.WriteLine("What will you do?\n1. C\n2. H\n3. H\nOr\n4. Quit");
            SetUp.GetTierChoice[0] = Console.ReadLine();

            while(String.IsNullOrEmpty(SetUp.GetTierChoice[1]))
            {
                //Tell player option was empty
                Console.WriteLine("You didn't choose anything. The game can't continue otherwise.");
                Console.WriteLine("What will you do?\n1. C\n2. H\n3. H\nOr\n4. Quit");
                SetUp.GetTierChoice[1] = Console.ReadLine();
            }

            SetUp.SetValidateChoice = int.TryParse(SetUp.GetTierChoice[1], out SetUp.GetTierChoiceNum[1]);

            while(SetUp.GetValidateChoice != true || SetUp.GetTierChoiceNum[1] > 4)
            {
                Console.WriteLine("Your input was invalid. Please choose between your four options.");

                SetUp.GetTierChoice[1] = Console.ReadLine();
                while (String.IsNullOrEmpty(SetUp.GetTierChoice[1]))
                {
                    Console.WriteLine("You didn't choose anything. The game can't continue otherwise.");
                    Console.WriteLine("What will you do?\n1. C\n2. H\n3. H\nOr\n4. Quit");
                    SetUp.GetTierChoice[1] = Console.ReadLine();
                }

                SetUp.SetValidateChoice = int.TryParse(SetUp.GetTierChoice[1], out SetUp.GetTierChoiceNum[1]);
            }
            return SetUp.GetTierChoiceNum[1];
        }

        public static int Scenario1(string playerName)
        {

            Player.SetIntelligence = Player.GetIntelligence + 1;
            return Player.GetIntelligence;
        }

        public static int Scenario2(string playerName)
        {

            Player.SetKindness = Player.GetKindness + 1;
            return Player.GetKindness;
        }

        public static int Scenario3(string playerName)
        {

            Player.SetBoldness = Player.GetBoldness + 1;
            return Player.GetBoldness;
        }

        public static void PlayTier2()
        {
            switch (SetUp.GetTierChoiceNum[1])
            {
                case 1:
                    Scenario1(Player.GetPlayerName);
                    break;
                case 2:
                    Scenario2(Player.GetPlayerName);
                    break;
                case 3:
                    Scenario3(Player.GetPlayerName);
                    break;
                case 4:
                    SetUp.QuitGame();
                    break;
                default:
                    SetUp.QuitGame();
                    break;
            }
        }

        public static int TierConclusion()
        {
            
            switch (SetUp.GetTierChoiceNum[1])
            {
                case 1:
                    //t1o = 1;
                    SetUp.GetTierOutcome[1] = 1;
                    break;
                case 2:
                    //t1o = 2;
                    SetUp.GetTierOutcome[1] = 2;
                    break;
                case 3:
                    //t1o = 3;
                    SetUp.GetTierOutcome[1] = 3;
                    break;
                default:
                    Console.WriteLine("I don't know how no Scenario is playing right now, but without that the game can't continue.\nLooks like we'll have to abort.");
                    Environment.Exit(0);
                    break;
            }

            return SetUp.GetTierOutcome[1];
        }

    }
}
