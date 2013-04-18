using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }

            // Constructor that takes individual property values
            public Dog(string name, int age)
            {
                Name = name;
                Age = age;
            }

            // Copy constructor
            public Dog(Dog otherDog)
            {
                Name = otherDog.Name;
                Age = otherDog.Age;
            }
        }

        static void Main(string[] args)
        {
            // Create a dog
            Dog myDog = new Dog("Kirby", 15);

            // Create a copy of Kirby
            Dog other = new Dog(myDog);
        }
    }
}
