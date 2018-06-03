using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Basic 'Hello World' console application to demonstrate C# understanding
 */

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Please enter a message to display.");
            var input = Console.ReadLine();
            Console.WriteLine("Displaying message: {0}", input);
            Console.WriteLine("Press enter to exit.");
            input = Console.ReadLine();
        }
    }
}
