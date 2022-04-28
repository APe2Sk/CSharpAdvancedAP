// See https://aka.ms/new-console-template for more information

using classes;
using classes.Entities;

Dog dog1 = new Dog() { Name = "Barky", Age = 3, FavoriteFood = "bones", GoodBoy = true, Type = "labrador"};
Dog dog2 = new Dog() { Name = "Sarko", Age = 1, FavoriteFood = "meat", GoodBoy = false, Type = "koker" };

Cat cat1 = new Cat() { Name = "Mj", Age = 1, Lazy = true, LivesLeft = 3, Type = "normal" };
Cat cat2 = new Cat() { Name = "Al", Age = 4, Lazy = false, LivesLeft = 1, Type = "normal" };

Fish fish1 = new Fish() { Name = "Ripka", Age = 2, Color = "gold", Size = 3, Type = "normal" };
Fish fish2 = new Fish() { Name = "Bu", Age = 1, Color = "silver", Size = 2, Type = "normal" };

PetStore<Dog> dogStore = new PetStore<Dog>() { PetsList = new List<Dog> { dog1, dog2 } };
PetStore<Cat> catStore = new PetStore<Cat>() { PetsList = new List<Cat> { cat1, cat2} };

dogStore.BuyPet("Sarko");
catStore.BuyPet("al");

dogStore.PrintPets();
catStore.PrintPets();


Console.ReadLine();