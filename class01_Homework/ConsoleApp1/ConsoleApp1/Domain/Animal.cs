using ConsoleApp1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public EnumType Type { get; set; }


        public abstract void PrintAnimal();
    }
}
