using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class RoomEvent
    {
        private bool _item;

        public RoomEvent()
        { 
            Item = _item;
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
    }


}
