using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Program
    {
        //
        // Class for the main method
        //

        static void Main(string[] args)
        {
            try
            {
                Game game = new Game();
                game.Start();
            }
            catch
            {
                Console.WriteLine("UNEXPECTED ERROR!");
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
