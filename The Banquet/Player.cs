using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
