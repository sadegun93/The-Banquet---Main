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
    public static class Player
    {
        //Player stats that are increased based on the choices that are made during the game
        static int intelligence = 1;
        public static int GetIntelligence
        {
            get
            {
                return intelligence;
            }
        }
        public static int SetIntelligence
        {
            set
            {
                intelligence = value;
            }
        }

        static int boldness = 1;
        public static int GetBoldness
        {
            get
            {
                return boldness;
            }
        }
        public static int SetBoldness
        {
            set
            {
                boldness = value;
            }
        }

        static int kindness = 1;
        public static int GetKindness
        {
            get
            {
                return kindness;
            }
        }

        public static int SetKindness
        {
            set
            {
                kindness = value;
            }
        }

        //player name variables
        static string nameSelection;
        public static string GetNameSelection
        {
            get
            {
                return nameSelection;
            }
        }
        public static string SetNameSelection
        {
            set
            {
                nameSelection = value;
            }
        }

        public static int nameSelectionNum;

        static bool validateName;

        public static bool GetValidateName
        {
            get
            {
                return validateName;
            }
        }
        public static bool SetValidateName
        {
            set
            {
                validateName = value;
            }
        }

        static string playerName;
        public static string GetPlayerName
        {
            get
            {
                return playerName;
            }
        }
        public static string SetPlayerName
        {
            set
            {
                playerName = value;
            }
        }
    }
}
