using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace DungeonExplorer
{
    public class Room
    {
        // the room should have a description and an event or item
        // getting / setting is necessary
        private string _description;
        private RoomEvent _roomEvent;

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
        public RoomEvent RoomEvent
        {
            get { return _roomEvent; }
            set
            {
                _roomEvent = value;
            }
        }

        public string GetDescription()
        {
            return Description;
        }

    }
}