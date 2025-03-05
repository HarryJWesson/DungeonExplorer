using System.Diagnostics.Tracing;

namespace DungeonExplorer
{
    public class Room
    {
        // the room should have a description and an event or item
        // getting / setting is necessary
        private string description;
        private RoomEvent roomEvent;

        public Room(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }
    }
}