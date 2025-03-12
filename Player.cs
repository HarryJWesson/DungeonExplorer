using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace DungeonExplorer
{
    public class Player
    {
        // make sure the following are initialised properly for basic credits
        // getting / setting is necessary
        
        // need a method to get the description of the room
        
        public string Name { get; private set; }
        public int Health { get; private set; }
        private List<string> inventory = new List<string>();

        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }

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

        public int MoveToNextRoom(Room Room)
        {
            return Room.NextRoom;
        }

        public string InventoryContents()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name}'s health is {Health}.");
            return string.Join(", ", inventory);
        }
    }
}