using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    class GameMap
    {
        public List<Room> rooms;
        public Room currentRoom;

        public GameMap() 
        {
            rooms = new List<Room>();

            Weapon sword = new Weapon("Old Sword", "A rusty blade! Might be useful for your adventures!");
            currentRoom = new Room("The entrance to the dungeon!", 0, 1, sword);
            rooms.Add(currentRoom);

            Potion healingPot = new Potion("Healing Potion","A strange red liquid in a conviently small vial! It tastes of warm oranges!");
            Room tempRoom = new Room("A small lab with shelves filled with vials of peculiar colours.", 1, 2, healingPot);
            rooms.Add(tempRoom);

            Potion damagePot = new Potion("Damage Potion", "There's something about this potion that makes you seething with rage!");
            Room tempRoom1 = new Room("A small shrine with a contraption that seems to funnel a strange liquid into a small black potion.", 2, 3, damagePot);
            rooms.Add(tempRoom1);

            Weapon claymore = new Weapon("Claymore", "This claymore was nearly too big to be called a sword. Too big, too thick, too heavy, and too rough, it was more like a large hunk of iron.");
            Room tempRoom2 = new Room("A collapsed room that seemed to have been an armoury!", 3, 4, claymore);
            rooms.Add(tempRoom2);

            Item treasure = new Item("A huge heap of gold!", "Glimmering, shiny GOLD! Take heed of greed though: The treasure is likely to be your death, though the dragon is no more!");
            Room tempRoom3 = new Room("A treasury with mountains of gold beyond price and count!", 4, 5, treasure);
            rooms.Add(tempRoom3);

            Console.WriteLine();
        }
    }
}
