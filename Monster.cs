using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Monster : Creature, IDamageable
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackDamage { get; private set; }

        public Monster(string name, int health, int attackDamage)
        {
            Name = name;
            Health = health;
            AttackDamage = attackDamage;
        }
        public override void Attack(Creature target)
        {
            target.Damage(this.AttackDamage);
        }

        public override void Damage(int Damage) 
        { 
            int tempHealth = this.Health - Damage;
            this.Health = tempHealth;
        }
    }
}
