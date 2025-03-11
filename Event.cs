using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Event
    {
        private bool _item;
        private string _name;

        public Event(bool _item)
        { 
            Item = _item;
            Name = _name;
        }

        public bool Item
        {
            get { return _item; }
            set
            {
                _item = value;
            }
        }

        public string Name
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
    }


}
