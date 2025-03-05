using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        // make sure the following are initialised properly for basic credits
        // getting / setting is necessary
        
        // need a method to get the description of the room
        
        // error checking with the inputting of the name or trying to pick an item that isnt there
        public string Name { get; private set; }
        public int Health { get; private set; }
        private List<string> inventory = new List<string>();

        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }
        public void PickUpItem(string item)
        {

        }
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }
    }
}