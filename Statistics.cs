using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Statistics
    {
        public static int level = 0;
        public static int monsterKills = 0;

        public static void Update() 
        {
            level = monsterKills / 2;
        }
    }
}
