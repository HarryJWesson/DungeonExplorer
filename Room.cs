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
        public Monster Monster { get; set; }
        private int _roomIndex;
        private int _nextRoom;
        public string RoomType { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool GhostSpawned { get; set; }
        public bool KeySpawned { get; set; }


        // Constructor that generates items and monsters
        public Room(string _description, int _roomIndex, int _nextRoom, Item _item, Monster _monster)
        {
            Description = _description;
            Item = _item;
            Monster = _monster;
            RoomIndex = _roomIndex;
            Question = "null";
            RoomType = "Room";
            GhostSpawned = true;
            KeySpawned = true;
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
            if (this.Monster.Health > 0)
            {
                Console.WriteLine($"The monster in the room is a {this.Monster.Name}");
            }
            Console.WriteLine();
            if (!this.Item.IsCollected)
            {
                Console.WriteLine($"There is an item in the room. It's a {this.Item.Name}");
            }
            return Description;
        }

        public Room(string _description, int _roomIndex, int _nextRoom, Item _item, Monster _monster, string roomType) 
        {
            Description = _description;
            Item = _item;
            Monster = _monster;
            RoomIndex = _roomIndex;
            NextRoom = _nextRoom;
            GhostSpawned = false;
            Question = "null";
            KeySpawned = false;
            RoomType = roomType;
        }

        public Room(string _description, int _roomIndex, int _nextRoom, Item _item, Monster _monster, string roomType, string question, string answer)
        {
            Description = _description;
            Item = _item;
            Monster = _monster;
            RoomIndex = _roomIndex;
            NextRoom = _nextRoom;
            RoomType = roomType;
            GhostSpawned = false;
            KeySpawned = false;
            Question = question;
            Answer = answer;
            Console.WriteLine("EGADS");
        }

        public void Riddle() 
        {
            while (Question != "null") 
            {
                Console.WriteLine(Question);
                Console.WriteLine("Your answer?: ");
                Console.WriteLine();

                string attempt = Console.ReadLine();

                if (attempt == Answer) { Question = "null"; Console.WriteLine("Correct!"); }
                else { Console.WriteLine("Nothing happens..."); }
            }
        }
        public void Unlock()
        {
            if (Inventory.inventory.Exists(item => item.Name == "Key"))
            {
                Console.WriteLine("You've unlocked the door with your key!");
                Inventory.Drop("Key");
                this.RoomType = "Room";
            }
        }
    }
}