using System;
using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace DungeonExplorer
{
    public class Room
    {
        //
        // Class to represent a room and its properties
        //

        private string _description;
        public Item Item { get; set; }
        public Monster Monster { get; private set; }
        private int _roomIndex;
        private int _nextRoom;

        // Constructor that generates items and monsters
        public Room(string _description, int _roomIndex, int _nextRoom, Item _item, Monster _monster)
        {
            Description = _description;
            Item = _item;
            Monster = _monster;
            RoomIndex = _roomIndex;
            NextRoom = _nextRoom;
        }

        // getter setter for description of the room
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }

        // getter setter for the index of the room
        public int RoomIndex
        {
            get { return _roomIndex; }
            set
            {
                _roomIndex = value;
            }
        }

        // getter setter for the index of the next room a player can move to
        public int NextRoom
        {
            get { return _nextRoom; }
            set
            {
                _nextRoom = value;
            }
        }

        // Method to show the description of the room
        public string GetDescription()
        {
            Console.WriteLine();
            Console.WriteLine($"The monster in the room is a {this.Monster.Name}");
            Console.WriteLine();
            Console.WriteLine($"There is an item in the room. It's a {this.Item.Name}");
            return Description;
        }

    }
}