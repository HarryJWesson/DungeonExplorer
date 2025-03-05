using System;
using System.Media;
using System.Xml.Serialization;

namespace DungeonExplorer
{
    internal class Game
    {
  
        private Player player;
        private Room currentRoom;

        // This constructor inits the player and room
        public Game()
        {
            currentRoom = new Room("The first room");
            
            Console.WriteLine("Please input the player's name: ");
            string name = Console.ReadLine();
            player = new Player(name, 100);

        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                // Code your playing logic here
                turn();
            }
        }

        public void turn()
        {
            try
            {
                Console.WriteLine("Please input the relative number for your choice:  ");
                Console.WriteLine("1: View the room");
                Console.WriteLine("2: Check player stats");
                Console.WriteLine("3: Pick up the item in the room (If there is one)");
                Console.WriteLine("---------------------------");
                int choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please input a valid choice!");
            }
        }
    }
}