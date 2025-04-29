using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public abstract class Creature
    {
        public abstract void Attack(Creature target);
        public abstract void Damage(int Damage);
        
    }
}
