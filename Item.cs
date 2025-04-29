using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Item : ICollectable
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsCollected { get; private set; } = false;
        public string itemType { get; set; }

        public Item(string name, string description)
        { 
            Name = name;
            Description = description;
            itemType = "Generic Item";
        }

        public void Collect(Player player)
        {
            if (!IsCollected)
            {
                Console.WriteLine($"You picked up a {this.Name}!");
                player.PickUpItem(this);
                this.IsCollected = true;
            }
            else { Console.WriteLine("The item has already been collected!"); }
        }

        public virtual void Use(Player player) 
        {
            Console.WriteLine("No use case is set for this item! Here's its description: ");
            Console.WriteLine();
            Console.WriteLine($"{this.Description}");
        }
    }
}
