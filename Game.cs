using System;
using System.Media;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace DungeonExplorer
{

    internal class Game
    {
        //
        // Class that holds all the game logic
        //
  
        private Player player;
        private GameMap map;

        // This constructor inits the player and room
        public Game()
        {
            map = new GameMap();

            Console.WriteLine("Please input the player's name: ");
            string name = Console.ReadLine();
            player = new Player(name, 100);
            Weapon fists = new Weapon("Fists", "Your trusty fists!", 5);
            player.Equipped = fists;
            Console.WriteLine();
        }

        // This class method contains the main game play loop
        public void Start()
        {
            bool playing = true;
            int finalRoom = 5;
            while (playing)
            {
                playing = turn(finalRoom);
            }
        }

        // Contains the logic for a turn in the game
        public bool turn(int finalRoom)
        {
            // Presents the options to console
            Console.WriteLine();
            Console.WriteLine("Please input the relative number for your choice:  ");
            Console.WriteLine("1: View the room");
            Console.WriteLine("2: Check player stats and inventory");
            Console.WriteLine("3: Pick up the item in the room (If there is one)");
            Console.WriteLine("4: Use an item or Equip an item");
            Console.WriteLine("5: Enter Combat!");
            Console.WriteLine("6: Move to the next room");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

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
                        break;

                    case 2:
                        // Check the player inventory and health

                        Console.WriteLine($"The player health is {player.Health}");
                        Console.WriteLine($"The player has {player.Equipped.Name} equipped. They deal {player.Equipped.Damage} damage!");
                        Inventory.Inspect();
                        break;

                    case 3:
                        // Pick up an Item in the room
                        map.currentRoom.Item.Collect(player);
                        break;

                    case 4:
                        Inventory.UseItemMenu(player);
                        break;

                    case 5:
                        // Enter combat with the monster

                        Console.WriteLine($"The monster is a {map.currentRoom.Monster.Name}!");

                        if (map.currentRoom.Monster.Health > 0) 
                        {
                            while (map.currentRoom.Monster.Health >= 0 && player.Health >= 0)
                            {
                                Console.WriteLine($"The monster's health is {map.currentRoom.Monster.Health}, Your health is {player.Health}");
                                Console.WriteLine();
                                Console.WriteLine("ENTER 1 TO ATTACK OR 2 TO USE AN ITEM!");
                                Console.WriteLine();
                                String combatChoice = Console.ReadLine();
                                Console.WriteLine();
                                switch (combatChoice) 
                                {
                                    case "1":
                                        map.currentRoom.Monster.Damage(player.Equipped.Damage);
                                        break;

                                    case "2":
                                        Inventory.UseItemMenu(player);
                                        break;

                                    default: 
                                        Console.WriteLine("You have input an invalid option! You stumble around the room and miss your turn!");
                                        break;

                                }

                                if (map.currentRoom.Monster.Health > 0)
                                {
                                    player.Damage(map.currentRoom.Monster.AttackDamage);
                                }

                                if (player.Health <= 0) 
                                {
                                    Console.WriteLine("You fall to the monster's might! Better luck next time!");
                                    return false;
                                }
                            }
                            if (map.currentRoom.Monster.Health <= 0) { Console.WriteLine("Congratulations! You beat the monster!"); }
                        }
                        break;

                    case 6:
                        // Move to the next room
                        if (map.currentRoom.Monster.Health <= 0) 
                        {
                            int nextIndex = player.MoveToNextRoom(map);
                            if (nextIndex < finalRoom)
                            {
                                map.currentRoom = map.rooms[nextIndex];
                                Console.WriteLine();
                                Console.WriteLine(map.currentRoom.GetDescription());
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("End of the Line!");
                                Console.WriteLine();
                                return false;
                            } 
                        }
                        else {  Console.WriteLine($"You can't leave! A {map.currentRoom.Monster.Name} blocks your path!"); }
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
            return true;
        }
    }
}