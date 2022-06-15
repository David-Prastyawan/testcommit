using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcommit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default Foreground Color: {0}",
                                  Console.ForegroundColor);

            // Set the Foreground color to blue
            Console.ForegroundColor
                = ConsoleColor.Blue;

            // Display current Foreground color
            Console.WriteLine("Changed Foreground Color: {0}",
                                    Console.ForegroundColor);
            Console.ReadKey();
        }
    }
}
