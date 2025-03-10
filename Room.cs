using System;
using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace DungeonExplorer
{
    public class Room
    {
        private string _description;
        private Event _roomEvent = new Event(true);
        private int _roomIndex;
        private int _nextRoom;

        public Room(string _description, int _roomIndex, int _nextRoom)
        {
            Description = _description;
            RoomEvent = _roomEvent;
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

        public Event RoomEvent
        {
            get { return _roomEvent; }
            set
            {
                _roomEvent = value;
            }
        }

        public string GetDescription()
        {
            if (RoomEvent.Item == true) 
            {
                Console.WriteLine($"There is an item in the room! It is a {RoomEvent.Name}");
            }

            return Description;
        }

    }
}