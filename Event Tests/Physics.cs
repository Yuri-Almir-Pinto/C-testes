using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTeste.Event_Tests
{
    class Physics
    {
        public static void falling(string height)
        {

            Console.WriteLine($"Player is falling from a height of {height} meters!");
        }

        public static void fell(string damage)
        {
            Console.WriteLine($"Player fell! Took {damage} damage");
        }
    }
}
