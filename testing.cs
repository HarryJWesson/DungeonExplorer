using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Testing
    {
        public static void tests()
        {
            // test #1 see if room description is correct
            Room testroom = new Room("test description", 0, 1);
            Debug.Assert(testroom.GetDescription() == "test description", "test 1 has failed. incorrect return");
            Console.WriteLine("If this is the only message you see test number 1 has succeeded");

            // test #2 to see if only room index 2 generates a monster
            Room testroomwithamonster = new Room("test", 2, 3);
            Debug.Assert(testroomwithamonster.Monster.Item ==  false, "test 2 has failed. no monster");
            Console.WriteLine("If this is the only message you see test number 2 has succeeded");

            // test #3 to see player inventory in a room with two items
            Player testplayer = new Player("Harry", 100);
            testplayer.PickUpItem(testroom);
            Console.WriteLine(testplayer.InventoryContents());
        }
    }
}
