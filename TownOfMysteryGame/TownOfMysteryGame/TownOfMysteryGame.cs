using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TownOfMysteryGame
{
    class TownOfMysteryGame
    {
        static void Main(string[] args)
        {
            Game.Start();
        }
    }
    class Game
    {
        /** Starts the game.
         */
        public static void Start()
        {
            ;
        }

        /** Displays the title screen.
         */
        static void PlayTitle()
        {
            ;
        }

        /** Get the player's name.
         */
        static string GetName(string playerInput)
        {
            String name = null;
            return name;
        }

        /** Display the final screen of the game when game over is encountered.
         */
        void GameOver()
        {
            ;
        }

        /** Sets the game over flag from false to true.
         */
        bool GameEnd(bool isGameOver)
        {
            if (!isGameOver)
            {
                isGameOver = true;
            }
            return isGameOver;
        }
    }

    class Text
    {
        /// <summary>
        /// Prints text given to it formatted for the game screen.
        /// </summary>
        /// <param name="textToBePrinted"></param>
        void PrintText(string[] textToBePrinted)
        {
            WriteLine(textToBePrinted);
        }

        /** Prepares the screen for printing text.
         */
        void PrimeForPrint()
        {
            ;
        }

        /** Sets the cursor to the default printing position.
         */
        void SetCursorDefault()
        {
            ;
        }

        /** Reads a text file and creates a string array.
         */
        string[] ParseContent(string[] textFile)
        {
            string[] text = null;
            return text;
        }
    }

    class HUD
    {
        /** Draws the Game's HUD when called.
         */
        void DrawHUD()
        {
            ;
        }
    }
    class Inventory
    {
        /** Builds the inventory from the database when called.
         */
        void BuildInventory()
        {
            ;
        }

        /** Sets the player's starting inventory.
         */
        void InitializeInventory()
        {
            ;
        }

        Dictionary<String, int> ParseItems(Map inventoryFile)
        {
            var Inventory = new Dictionary<String, int>();
            return Inventory;
        }

        /** Prints out the player's inventory.
         */
        void PrintInventory()
        {
            ;
        }

        /** Returns whether the player can pick up an item or not.
         */
        bool CheckWeight(int playerWeight)
        {
            bool canPickUp = false;
            return canPickUp;
        }

        /** Drops an item from the inventory.
         */
        void DropItem()
        {
            ;
        }
    }

    class Map
    {
        /** Builds the map by reading in excel map file.
         */
        void BuildMap()
        {
            ;
        }

        /** Check if the integer passed is a valid map point.
         */
        bool CheckMap(int cardinalDirection)
        {
            bool validDirection = false;
            return validDirection;
        }
    }

    class Room
    {
        /** Set's last room location when moving rooms.
         */
        int SetLastRoom(int currentRoom)
        {
            int lastRoom = currentRoom;
            return lastRoom;
        }

        /** Sends player to the room they asked for.
         */
        void GoToRoom()
        {
            ;
        }

        /** Sends player to the last room visited when they say to go back.
         */
        void GoToLastRoom(int lastRoom)
        {
            ;
        }

    }

    class Input
    {
        /** Checks player input for keywords.
         */
        void ParseInput()
        {
            ;
        }

        /** Take the keywords from parse input and check against current room keywords.
         */
        void CheckKeywords()
        {
            ;
        }

        /** Takes player's input and makes sure it is valid.
         */
        bool ValidateInput(string input)
        {
            bool isValid = false;
            return isValid;
        }
    }
}
