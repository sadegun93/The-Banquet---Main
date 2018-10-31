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

            //These ints will be used to convert the Tier selections to variables that can be used in the main method.
            //Their naming scheme is as thus:
            //tXs- Tier X Scenario
            //t1s = Tier 1 Scenario
            int t1s;

            int gameColorMain;
            string playerNameMain;

            //Introduction Class Color selection method to let players choose what the game looks like
            gameColorMain = Introduction.ColorSelection();

            switch (gameColorMain)
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

            //Game Title comes after Color Selection
            Console.WriteLine("Welcome to The Banquet. A wondrous night awaits you after a day of merryment.");
            Console.WriteLine("--------------------------------------------------------------------------");

            //Introduction Class Rules method to let players know how the game works
            Introduction.Rules();
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------");

            //Introduction Class Welcome method to introduce players to the game and grab their name
            playerNameMain = Introduction.Welcome();

            //Console.ReadLine();
            Console.WriteLine("Ah, yes! Onwards, Lord " + playerNameMain + "! Let us see what awaits you in the Jewel of the Empire!");
            Console.WriteLine("In this beautiful city of Ferenicia!");

            Console.ReadLine();

            t1s = Tier1.Introduction();

            Console.ReadLine();
            //Console.WriteLine(t1s);

            switch (t1s)
            {
                case 1:
                    Tier1.Scenario1(Player.playerName);
                    break;
                case 2:
                    Tier1.Scenario2(Player.playerName);
                    break;
                case 3:
                    Tier1.Scenario3Pt1(Player.playerName);
                    Tier1.Scenario3Pt2(Player.playerName);
                    break;
                default:
                    Console.WriteLine("I don't know how no Scenario is playing right now, but without that the game can't continue.\nLooks like we'll have to abort.");
                    Environment.Exit(0);
                    break;
            }

            Console.ReadLine();

            Tier1.Conclusion();

            Console.WriteLine(Player.intelligence);
            Console.WriteLine(Tier1.t1o);
            Console.WriteLine(Tier1.tapestry);

        }
    }
}
