using System;
using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace DungeonExplorer
{
    public class Room
    {
        private string _description;
        private Event _roomEvent = new Event(true);

        public Room(string _description)
        {
            Description = _description;
            RoomEvent = _roomEvent;
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
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