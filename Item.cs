﻿using System;
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

        public Item(string name, string description)
        { 
            Name = name;
            Description = description;
        }

        public void Collect(Room room, Player player)
        { }

        public virtual void Use() { }
    }
}
