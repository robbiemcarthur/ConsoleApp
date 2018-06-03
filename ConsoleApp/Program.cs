using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Basic 'Hello World' console application to demonstrate C# understanding
 * displaying simple message/computing sum of two integers
 */

namespace ConsoleApp
{
    class Program
    {
        private static string num1;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Please enter a message to display.");
            var input = Console.ReadLine();
            Console.WriteLine("Displaying message: {0}", input);
            bool go = true;
            while(go)
            {
                Console.WriteLine("Would you like to display another message? y/n");
                input = Console.ReadLine();
                if (input.Equals("y"))
                {
                    Console.WriteLine("Please enter a message to display.");
                    input = Console.ReadLine();
                    Console.WriteLine("Displaying message: {0}", input);
                }
                else
                {
                    go = false;
                }
            }
            bool sum = false;
            while(!sum)
            {
                Console.WriteLine("Would you like to compute a sum? y/n");
                input = Console.ReadLine();
                if (input.Equals("y"))
                {
                    Console.WriteLine("Please enter the first number of the computation");
                    string firstint = Console.ReadLine();
                    int x = Convert.ToInt32(firstint);
                    Console.WriteLine("Please enter the first number of the computation");
                    string secondint = Console.ReadLine();
                    int y = Convert.ToInt32(secondint);
                    int compute = x + y;
                    Console.WriteLine("{0} + {1} = {2}", x,y,compute);
                }
                else
                {
                    sum = true;
                }
            }
            Console.WriteLine("Press enter to exit.");
            input = Console.ReadLine();
        }
    }
}
