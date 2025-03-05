using System;
using System.Media;
using System.Xml.Serialization;

namespace DungeonExplorer
{
    internal class Game
    {
        // getting / setting is necessary
        private Player player;
        private Room currentRoom;

        public Game()
        {
            Room room = new Room("The first room");
            
            Console.WriteLine("Please input the player's name: ");
            string name = Console.ReadLine();

            Player player = new Player(name, 100);

        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                // Code your playing logic here
                // Present options the player can take > view the room, display health and inventory
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
}