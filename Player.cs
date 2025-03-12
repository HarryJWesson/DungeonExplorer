using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace DungeonExplorer
{
    public class Player
    {
        //
        // Class that represents the player and contains methods for actions in the game
        //

        public string Name { get; private set; }
        public int Health { get; private set; }
        private List<string> inventory = new List<string>();

        // Constructer for the player class
        // current properties mean all the setting is private and only settable at creation
        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }

        // method to check if items are present and the picks them up
        public void PickUpItem(Room room)
        {
            if ((room.Item.Item == true) & (room.Item.Present == true))
            {
                this.inventory.Add(room.Item.Name);
                room.Item.Present = false;
            }
            else if ((room.Monster.Item == true) & (room.Monster.Present == true))
            {
                this.inventory.Add(room.Monster.Name);
                room.Monster.Present = false;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No item to pick up!");
                Console.WriteLine();
            }
        }

        // Moves to the next room by returning the nextroom's index
        public int MoveToNextRoom(Room Room)
        {
            return Room.NextRoom;
        }

        // Method to print the health and return the inventory to be printed
        public string InventoryContents()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name}'s health is {Health}.");
            return string.Join(", ", inventory);
        }
    }
}