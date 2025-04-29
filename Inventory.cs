using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Inventory
    {
        public static List<Item> inventory = new List<Item>();
        public static int maxItems = 5;

        public static void UseItemMenu(Player player)
        {
            bool itemUsed = false;
            while (!itemUsed)
            {
                Console.WriteLine("Enter Y if you would like to inspect your inventory: ");
                Console.WriteLine();

                string inspectChoice = Console.ReadLine();

                if (inspectChoice == "Y") { Inspect(); }

                Console.WriteLine();
                Console.WriteLine("Please enter the name (as displayed before the :) of the item you wish to use or enter 'Cancel' to exit!");
                Console.WriteLine();

                string itemToFind = Console.ReadLine();

                if (itemToFind == "Cancel") { itemUsed = true; }

                bool itemExists = inventory.Exists(item => item.Name == itemToFind);

                if (itemExists)
                {
                    Item foundItem = inventory.First(item => item.Name == itemToFind);
                    foundItem.Use(player);
                    itemUsed = true;
                }
                else { Console.WriteLine("Item not found!"); }
            }
        }

        public static void Inspect()
        {
            bool inspecting = true;
            try
            {
                while (inspecting)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to look at your: ");
                    Console.WriteLine("1: Weapons");
                    Console.WriteLine("2: Potions");
                    Console.WriteLine("3: Everything");
                    Console.WriteLine("4: Your strongest weapon");
                    Console.WriteLine("5: Stop inspecting inventory");
                    Console.WriteLine();

                    string Choice = Console.ReadLine();
                    Console.WriteLine();

                    switch (Choice)
                    {
                        case "1":
                            Console.WriteLine("Displaying all weapons!");
                            List<Item> weapons = inventory.Where(item => item.itemType == "Weapon").ToList();

                            foreach (Weapon weapon in weapons)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"{weapon.Name} : {weapon.Description}");
                            }
                            break;

                        case "2":
                            Console.WriteLine("Displaying all potions!");

                            List<Item> potions = inventory.Where(item => item.itemType == "Potion").ToList();

                            foreach (Potion potion in potions)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"{potion.Name} : {potion.Description}");
                            }
                            break;

                        case "3":
                            Console.WriteLine("Displaying all!");

                            foreach (Item item in inventory)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"{item.Name} : {item.Description}");
                            }

                            break;

                        case "4":
                            List<Item> temp = inventory.Where(item => item.itemType == "Weapon").ToList();

                            List<Weapon> orderDesc = new List<Weapon>();

                            foreach (Weapon weapon in temp)
                            {
                                orderDesc.Add(weapon);
                            }

                            Console.WriteLine();
                            Weapon Strongest = orderDesc.OrderByDescending(weapon => weapon.Damage).FirstOrDefault();
                            Console.WriteLine($"{Strongest.Name} is your most powerful weapon!");
                            Console.WriteLine();

                            break;

                        case "5":
                            Console.WriteLine();
                            Console.WriteLine("Closing the inventory!");
                            Console.WriteLine();
                            inspecting = false;
                            break;

                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
            }
            catch { Console.WriteLine("Error occurred while inspecting inventory!"); }
        }

        public static void Drop(string itemToRemove)
        {
            bool itemExists = inventory.Exists(item => item.Name == itemToRemove);

            if (itemExists) 
            {
                Item removedItem = inventory.First(item => item.Name == itemToRemove);
                inventory.Remove(removedItem);
            }
        }
    }
}