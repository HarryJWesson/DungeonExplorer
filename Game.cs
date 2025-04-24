using System;
using System.Media;
using System.Xml.Serialization;

namespace DungeonExplorer
{
    /// <summary>
    /// 
    /// Add new classes:
    /// monster, item, inventory, gamemap
    /// 
    /// - monster: represents creatures in rooms
    /// - Item: represents multiple types of items like weapons or potions
    /// - Inventory: a collection to manage items
    /// 
    /// LINQS and Lambda:
    /// LINQ to filter inventory or find strongest monster
    /// use lambda for sorting or filtering
    /// 
    /// Static and Dynamic Polymorphism:
    /// implement polymorphic methods for monster attacks or items based off of what they are
    /// 
    /// Error Checking:
    /// enhance error checking for invalid commands or interactions (trying to use a nonexistent item)
    /// 
    /// Game Expansion:
    /// add the following features
    /// 
    /// - battle monsters with varying difficulty
    /// - Manage an inventory
    /// 
    /// </summary>

    internal class Game
    {
        //
        // Class that holds all the game logic
        //
  
        private Player player;
        private Room currentRoom;
        private GameMap map;

        // This constructor inits the player and room
        public Game()
        {
            map = new GameMap();

            Console.WriteLine("Please input the player's name: ");
            string name = Console.ReadLine();
            player = new Player(name, 100);
            Console.WriteLine();
        }

        // This class method contains the main game play loop
        public void Start()
        {
            bool playing = true;
            int finalRoom = 3;
            while (playing)
            {
                turn(finalRoom);
            }
        }

        // Contains the logic for a turn in the game
        public void turn(int finalRoom)
        {
            // Presents the options to console
            Console.WriteLine("Please input the relative number for your choice:  ");
            Console.WriteLine("1: View the room");
            Console.WriteLine("2: Check player stats");
            Console.WriteLine("3: Pick up the item in the room (If there is one)");
            Console.WriteLine("4: Move to the next room");
            Console.WriteLine("---------------------------");

            // try catch statement to handle errors for parsing the string input to int
            try
            {
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // Switch case statement to select the method call 
                switch (choice)
                {
                    case 1:
                        // Check the room description and see if there's items or a monster

                        Console.WriteLine(map.currentRoom.GetDescription());
                        Console.WriteLine();
                        break;
                    case 2:
                        // Check the player inventory and health

                        Console.WriteLine(player.InventoryContents());
                        break;
                    case 3:
                        // Pick up an Item in the room

                        map.currentRoom.item.Collect(map.currentRoom);
                        break;
                    case 4:
                        // Move to the next room

                        int nextIndex = player.MoveToNextRoom(map);
                        if (nextIndex < finalRoom)
                        { map.currentRoom = map.rooms[nextIndex]; }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("End of the Line!");
                            Console.WriteLine();
                        }
                        break;
                    default:
                        // Catches any input that isnt listed

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