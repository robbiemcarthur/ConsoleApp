using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 
namespace ConsoleApp
{
    class AnimalProgram
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Cat", "Meow", 2);
            Console.WriteLine("Hi, I am a " + a.GetType() + ", I am " + a.GetAge() + " years old");
            Console.WriteLine(a.GetNoise());
            Console.Read();
            AnimalFactory af = new AnimalFactory();
            for(int i = 0; i < 20; i++)
            {
                Console.ReadLine();
                a = af.GenerateAnimal();
                Console.WriteLine("Hi, I am a " + a.GetType() + ", I am " + a.GetAge() + " years old");
                Console.WriteLine(a.GetNoise());
                Console.ReadLine();
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
