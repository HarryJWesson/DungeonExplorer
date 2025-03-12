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
        private Event _item;
        private Event _monster;
        private int _roomIndex;
        private int _nextRoom;

        // Constructor that generates items and monsters
        public Room(string _description, int _roomIndex, int _nextRoom)
        {
            Description = _description;
            Item = new Event(true);
            Monster = new Event(false);
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

        // getter setter for generating the item in each room
        public Event Item
        {
            get { return _item; }
            set
            {
                _item = value;
            }
        }

        // getter setter for generating a monster in the 3 room
        public Event Monster
        {
            get 
            {
                return _monster;
            }
            set
            {
                // the first room is index 0 so room index 2 is room 3
                if (this.RoomIndex / 2 == 0)
                {
                    _monster = new Event(true);
                }
                else
                {
                    _monster = new Event(false);
                }
            }
        }

        // Method to print all the items in the room and if theres a monster in the room
        public string GetDescription()
        {
            Console.WriteLine();
            if ((Item.Item == true) & (Item.Present)) 
            {
                Console.WriteLine($"There is an item in the room! It is a {Item.Name}");
            }
            if (Monster.Item == false)
            {
                Console.WriteLine($"There is a monster in the room! It is a {Monster.Name}");
            }
            if ((Monster.Item == true) & (Monster.Present))
            {
                Console.WriteLine($"There is an additional item! It is a {Monster.Name}");
            }
            Console.WriteLine();
            return Description;
        }

    }
}