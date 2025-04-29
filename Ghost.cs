using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Ghost : Monster
    {
        public Ghost(string name, int health, int attackDamage) : base(name, health, attackDamage)
        {

        }

        public override void Attack(Creature target)
        {
            Console.WriteLine("The ghost hovers around threateningly!");
        }

        public override void Damage(int Damage)
        {
            int tempHealth = this.Health - Damage*2;
            this.Health = tempHealth;
        }
    }
}
