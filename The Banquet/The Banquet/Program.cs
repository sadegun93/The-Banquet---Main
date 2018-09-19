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
        }
    }
}
