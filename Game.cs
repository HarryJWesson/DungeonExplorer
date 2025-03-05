using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        // getting / setting is necessary
        private Player player;
        private Room currentRoom;

        public Game()
        {
            // Initialize the game with one room and one player

        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                // Code your playing logic here
                // Present options the player can take > view the room, display health and inventory
            }
        }
    }
}