using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class GameMap
    {
        public List<Room> rooms;
        public Room currentRoom;

        public GameMap() 
        {
            rooms = new List<Room>();

            Weapon sword = new Weapon("Old Sword", "A rusty blade! Might be useful for your adventures!", 10);
            Monster slime = new Monster("Slime", 15, 5);
            currentRoom = new Room("The entrance to the dungeon!", 0, 1, sword, slime);
            rooms.Add(currentRoom);

            Potion healingPot = new Potion("Healing Potion","A strange red liquid in a conviently small vial! It tastes of warm oranges!", 50, true);
            Goblin goblin = new Goblin("Goblin", 45, 10);
            Room tempRoom = new Room("A small lab with shelves filled with vials of peculiar colours.", 1, 2, healingPot, goblin);
            rooms.Add(tempRoom);

            Potion damagePot = new Potion("Damage Potion", "There's something about this potion that makes you seething with rage!", 10, false);
            Monster hobgoblin = new Monster("Slime", 20, 15);
            Room tempRoom1 = new Room("A small shrine with a contraption that seems to funnel a strange liquid into a small black potion.", 2, 3, damagePot, hobgoblin);
            rooms.Add(tempRoom1);

            Weapon claymore = new Weapon("Claymore", "This claymore was nearly too big to be called a sword. Too big, too thick, too heavy, and too rough, it was more like a large hunk of iron.", 50);
            Monster ogre = new Monster("Ogre", 50, 20);
            Room tempRoom2 = new Room("A collapsed room that seemed to have been an armoury!", 3, 4, claymore, ogre);
            rooms.Add(tempRoom2);

            Item treasure = new Item("huge heap of gold!", "Glimmering, shiny GOLD! Take heed of greed though: The treasure is likely to be your death, though the dragon may be no more!");
            Monster dragon = new Monster("Dragon", 100, 30);
            Room tempRoom3 = new Room("A treasury with mountains of gold beyond price and count!", 4, 5, treasure, dragon);
            rooms.Add(tempRoom3);

            Item book = new Item("book of eternal knowledge!", "The cover reads Necronom-o-nom-ocron. The binding seems familiar.");
            Goblin biggerGoblin = new Goblin("Goblin", 50, 20);
            Room tempRoom4 = new Room("A dungeon with a skeleton resting in the corner", 5, 6, book, biggerGoblin, "Locked");
            rooms.Add(tempRoom4);

            Item note = new Item("Old note", "The old note reads 42");
            Ghost ghost = new Ghost("Ghost", 100, 0);
            Room tempRoom5 = new Room("An eerie room with a talking statue", 6, 7, note, ghost, "Locked", "The statue asks for the answer to life, the universe and everything?!", "42");
            rooms.Add(tempRoom5);

            Console.WriteLine();
        }
    }
}
