using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    class Weapon : Item
    {
        public Weapon(string name, string description) : base(name, description)
        {

        }

        public override void Use() { }
    }
}
