using System.Collections.Generic;

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
            if (room.RoomEvent.Item == true)
            {
                this.inventory.Add(room.RoomEvent.Name);
            }
        }
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }
    }
}