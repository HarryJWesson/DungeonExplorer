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
            currentRoom = new Room("The first room", 0, 1);
            
            Console.WriteLine("Please input the player's name: ");
            string name = Console.ReadLine();
            player = new Player(name, 100);
            Console.WriteLine();
        }
        public void Start()
        {
            bool playing = true;
            int finalRoom = 3;
            while (playing)
            {
                turn(finalRoom);
            }
        }

        public void turn(int finalRoom)
        {
            Console.WriteLine("Please input the relative number for your choice:  ");
            Console.WriteLine("1: View the room");
            Console.WriteLine("2: Check player stats");
            Console.WriteLine("3: Pick up the item in the room (If there is one)");
            Console.WriteLine("4: Move to the next room");
            Console.WriteLine("---------------------------");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(currentRoom.GetDescription());
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine(player.InventoryContents());
                        break;
                    case 3:
                        player.PickUpItem(currentRoom);
                        break;
                    case 4:
                        int nextIndex = player.MoveToNextRoom(currentRoom);
                        if (nextIndex < finalRoom)
                        { currentRoom = new Room($"Generated room number {nextIndex}", nextIndex, nextIndex + 1); }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("End of the Line!");
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input a valid choice!");
            }
            catch (Exception)
            {
                Console.WriteLine("Generic ERROR!");
            }
        }
    }
}