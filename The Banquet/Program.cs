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
 */
namespace The_Banquet
{
    class Program
    {
        static void Main(string[] args)
        {
            //In The Banquet, players are a low ranking Magianan lord who was invited to a banquet by King Einhart.
            //Throughout the day leading up to the banquet, the player can go around the city interacting with its citizens.
            //Players have a number of stats that are increased whenever they complete an action.
            //At the end of the day, during the banquet, players meet with the King, and are rewards depending on what they did.
            //That reward is an ending that is determined by their highest stat at the end of the day.

            //Introduction Class Color selection method to let players choose what the game looks like
            SetUp.ColorSelection();
            
            //Game Title comes after Color Selection
            Console.WriteLine("Welcome to The Banquet. A wondrous night awaits you after a day of merryment.");
            Console.WriteLine("--------------------------------------------------------------------------");

            //Introduction Class Rules method to let players know how the game works
            SetUp.Rules();
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------");

            //Introduction Class Welcome method to introduce players to the game and grab their name
            SetUp.Welcome();

            //Console.ReadLine();
            Console.WriteLine("Ah, yes! Onwards, Lord " + Player.GetPlayerName + "! Let us see what awaits you in the Jewel of the Empire!");
            Console.WriteLine("In this beautiful city of Ferenicia!");

            Console.ReadLine();

            Tier1.Tier1Introduction();

            Console.ReadLine();
            //Console.WriteLine(t1s);

            Tier1.PlayTier1();

            Console.ReadLine();

            Tier1.Tier1Conclusion();

            Console.WriteLine(Player.GetIntelligence);
            Console.WriteLine(Player.GetKindness);
            Console.WriteLine(Player.GetBoldness);
            Console.WriteLine(SetUp.GetTierOutcome[0]);
            Console.WriteLine(Tier1.GetTapestry);

        }
    }
}
