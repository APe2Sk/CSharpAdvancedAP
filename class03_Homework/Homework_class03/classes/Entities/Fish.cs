using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set;}

        public override void PrintInfo()
        {
            Console.WriteLine($"The fish {Name} has {Color} color and {Size} size. {Type}");
        }
    }
}
