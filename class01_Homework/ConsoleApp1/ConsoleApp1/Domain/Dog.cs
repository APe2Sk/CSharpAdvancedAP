using ConsoleApp1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public class Dog : Animal, IDog
    {

        public void Bark()
        {
            Console.WriteLine($"The {Name} barks.");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"The animal of type {Type}, has a name {Name} and is {Age} years old and bark the whole day...");
        }
    }
}
