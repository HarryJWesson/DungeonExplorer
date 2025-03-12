using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Event
    {
        //
        // Class that populates rooms and represents items or monsters
        //

        private bool _item;
        private string _name;
        private bool _present;

        public Event(bool _item)
        // constructor for the class
        { 
            Item = _item;
            Name = _name;
            Present = true;
        }

        public bool Item
        // getter setter for a bool value that suggests if an event is an item or not
        {
            get { return _item; }
            set
            {
                _item = value;
            }
        }

        public string Name
        // getter setter for the name of the event
        {
            get { return _name; }
            set
            {
                if (this.Item == true)
                {
                    _name = "Item";
                }
                else 
                { 
                    _name = "Monster";
                }
            }
        }

        public bool Present 
        // getter setter for whether the event is present in the room
        { 
            get { return _present; }
            set 
            {
                _present = value;
            } 
        }
    }


}
