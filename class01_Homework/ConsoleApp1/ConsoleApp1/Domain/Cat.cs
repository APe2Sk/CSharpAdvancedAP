using ConsoleApp1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public class Cat : Animal, ICat
    {

        public void Eat(string food)
        {
            Console.WriteLine($"The {Name} eats a lot of {food}");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"The animal of type {Type}, has a name {Name} and is {Age} years old and eat the whole day...");

        }
    }
}
