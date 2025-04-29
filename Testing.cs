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
        //
        // Testing class with methods to call to test some methods
        //

        public static void tests()
        {
            // test #1 see if room description is correct
            Item testitem = new Item("TestITem","Testing");
            Monster testmonster = new Monster("TestMonster", 100, 100);
            Room testroom = new Room("test description", 0, 1, testitem, testmonster);
            Debug.Assert(testroom.GetDescription() == "test description", "test 1 has failed. incorrect return");
            Console.WriteLine("If this is the only message you see test number 1 has succeeded");

            // test #2 to see if the item is present
            Debug.Assert(testroom.Item.Name == "TestITem", "Test 2 has failed. Incorrect return");
            Console.WriteLine("If this is the only message you see test number 2 has succeeded");


            // test #3 to see if the monster's health and damage is correct
            Debug.Assert(testroom.Monster.Health == 100, "Test 3 has failed. Incorrect return");
            Debug.Assert(testroom.Monster.AttackDamage == 100, "Test 3 has failed. Incorrect return");
            Console.WriteLine("If this is the only message you see test number 3 has succeeded");
        }
    }
}
