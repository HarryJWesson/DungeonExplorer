using System;
using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace DungeonExplorer
{
    public class Room
    {
        private string _description;
        private Event _item = new Event(true);
        private Event _monster = new Event(false);
        private int _roomIndex;
        private int _nextRoom;

        public Room(string _description, int _roomIndex, int _nextRoom)
        {
            Description = _description;
            Item = _item;
            Monster = _monster;
            RoomIndex = _roomIndex;
            NextRoom = _nextRoom;
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }

        public int RoomIndex
        {
            get { return _roomIndex; }
            set
            {
                _roomIndex = value;
            }
        }

        public int NextRoom
        {
            get { return _nextRoom; }
            set
            {
                _nextRoom = value;
            }
        }

        public Event Item
        {
            get { return _item; }
            set
            {
                _item = value;
            }
        }

        public Event Monster
        {
            get 
            {
                if (this.RoomIndex / 2 == 0)
                {
                    return new Event(true);
                }
                else
                {
                    return new Event(false);
                }
            }
            set
            {
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

        public string GetDescription()
        {
            if (Item.Item == true) 
            {
                Console.WriteLine($"There is an item in the room! It is a {Item.Name}");
            }
            if (Monster.Item == false)
            {
                Console.WriteLine($"There is a monster in the room! It is a {Monster.Name}");
            }
            else
            {
                Console.WriteLine($"There is an additional item! It is a {Monster.Name}");
            }
            return Description;
        }

    }
}