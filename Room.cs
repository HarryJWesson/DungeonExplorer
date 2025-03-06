using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace DungeonExplorer
{
    public class Room
    {
        // the room should have a description and an event or item
        // getting / setting is necessary
        private string _description;
        private RoomEvent roomEvent;

        public Room(string _description)
        {
            Description = _description;
            roomEvent = new RoomEvent();
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }

        public string GetDescription()
        {
            return Description;
        }

    }
}