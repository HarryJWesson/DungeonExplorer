using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class RoomEvent
    {
        private bool _item;
        private string _name;

        public RoomEvent()
        { 
            Item = _item;
            Name = _name;
        }

        public bool Item
        {
            get { return _item; }
            set
            { 
                if (value == false)
                {
                    var random = new Random();
                    _item = random.Next(2) == 1;
                }

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
                    _name = "No Item";
                }
            }
        }
    }


}
