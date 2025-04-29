using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    class Potion : Item
    {
        public int Strength { get; private set; }
        public bool Type { get; private set; }
        public bool Used { get; private set; } = false;

        public Potion(string name, string description, int strength, bool type) : base(name, description)
        {
            Strength = strength;
            Type = type;
            itemType = "Potion";
        }

        public override void Use(Player player) 
        {
            if (Type)
            {
                player.Health = (player.Health + this.Strength);
                this.Used = true;
            }
            else
            {
                player.Equipped.Damage += this.Strength;
                this.Used = false;
            }
        }
    }
}
