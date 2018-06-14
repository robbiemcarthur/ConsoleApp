using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class AnimalFactory
    {
        string[] Types = new string[] { "cat", "dog", "rabbit", "sheep", "cow", "pig" };
        string[] Noises = new string[] { "meow", "woof", "rmph", "baaa", "moo", "oink" };

        public Animal GenerateAnimal()
        {
            Random rand = new Random();
            int x = rand.Next(0,5);
            Animal a = new Animal(Types[x], Noises[x], rand.Next(1,10));
            return a;
        }
    }
}
