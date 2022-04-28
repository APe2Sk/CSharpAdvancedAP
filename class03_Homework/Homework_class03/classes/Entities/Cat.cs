using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.Entities
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"The cat {Name} has {LivesLeft} lives left. {Type}");
        }
    }
}
