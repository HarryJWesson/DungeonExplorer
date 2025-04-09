using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    class Monster : Creature, IDamageable
    {
        public Monster() { }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public void Damage() { }
    }
}
