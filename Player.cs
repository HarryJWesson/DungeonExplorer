using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace DungeonExplorer
{
    public class Player : Creature, IDamageable
    {
        //
        // Class that represents the player and contains methods for actions in the game
        //

        public string Name { get; private set; }
        public int Health { get; set; }
        public Weapon Equipped { get; set; }

        // Constructer for the player class
        // current properties mean all the setting is private and only settable at creation
        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }

        // method to check if items are present and the picks them up
        public void PickUpItem(Item item)
        {
            Inventory.inventory.Add(item);
        }

        // Moves to the next room by returning the nextroom's index
        public int MoveToNextRoom(GameMap gameMap)
        {
            return gameMap.currentRoom.NextRoom;
        }

        public override void Attack(Creature target)
        {
            target.Damage(this.Equipped.Damage);
        }

        public override void Damage(int damage) 
        {
            this.Health -= damage;
        }
    }
}