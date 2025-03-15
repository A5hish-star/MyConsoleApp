using System;

namespace MyconsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world from my console app!");

            // If the "--no-wait" argument is not provided, wait for user input.
            if (!Array.Exists(args, arg => arg == "--no-wait"))
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
