using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.Entities
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"The dog {Name} favorite food is {FavoriteFood}. Trye: {Type}");
        }
    }
}
