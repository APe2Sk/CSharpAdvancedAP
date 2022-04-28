using classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class PetStore<T> where T : Pet
    {
        public List<T> PetsList { get; set; }
        public void PrintPets()
        {
            Console.WriteLine("Print all pets in the store:");
            foreach (T pet in PetsList)
            {
                Console.WriteLine($"{pet.Name}");
            }
        }
        public void BuyPet(string name)
        {
            T itemToRemove = PetsList.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            if (itemToRemove != null)
            {
                PetsList.Remove(itemToRemove);
                Console.WriteLine($"Success, you bought {itemToRemove.Name}, your new pet");
            }
            else
            {
                Console.WriteLine($"There isn't any pet by name {name}");
            }
        }
    }
}
