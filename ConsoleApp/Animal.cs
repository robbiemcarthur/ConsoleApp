using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Animal class, highest level of inheritance
 * base class displaying knowledge of 
 * inheritance and polymorphism
 */
namespace ConsoleApp
{
    class Animal
    {
        private string type;
        private string noise;
        private int age;

        public Animal(string type, string noise, int age)
        {
            this.type = type;
            this.noise = noise;
            this.age = age;
        }

        public Animal()
        {

        }

        // GETTERS
        public void SetType(string type)
        {
            this.type = type;
        }

        public void SetNoise(string noise)
        {
            this.noise = noise;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        // SETTERS
        public string GetType()
        {
            return this.type;
        }

        public string GetNoise()
        {
            return this.noise;
        }

        public int GetAge()
        {
            return this.age;
        }
    }
}
