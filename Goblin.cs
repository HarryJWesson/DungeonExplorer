using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Goblin : Monster
    {
        static int goblinCrit = 1;
        public Goblin(string name, int health, int attackDamage) : base(name, health, attackDamage)
        { }

        public override void Attack(Creature target)
        {
            Console.WriteLine("The Goblin lashes out violently!");
            target.Damage(this.AttackDamage*goblinCrit);
            goblinCrit++;
        }

        public override void Damage(int Damage)
        {
            Console.WriteLine($"The goblin is extremely weak and takes double damage!");
            int tempHealth = this.Health - Damage * 2;
            this.Health = tempHealth;
            if (this.Health < 10) { Console.WriteLine("The goblin flees in terror!"); this.Health = 0; }
        }
    }
}
