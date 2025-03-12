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

            // test #1 see if room description is correct
            Room testroomwithamonster = new Room("test", 2, 3);
            Debug.Assert(testroomwithamonster.Monster.Item ==  false, "test 2 has failed. no monster");
            Console.WriteLine("If this is the only message you see test number 2 has succeeded");

        }
    }
}
