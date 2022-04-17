// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Domain;

List<Animal> animals = new List<Animal>();

Cat cat1 = new Cat()
{
    Name = "Mac",
    Age = 2,
    Type = EnumType.CAT,
};
Cat cat2 = new Cat()
{
    Name = "Mjau",
    Age = 1,
    Type = EnumType.CAT,
};


Dog dog1 = new Dog()
{
    Name = "Sarko",
    Age = 5,
    Type = EnumType.DOG,
};
Dog dog2 = new Dog()
{
    Name = "Marko",
    Age = 15,
    Type = EnumType.DOG,
};

animals.Add(cat1);
animals.Add(cat2);
animals.Add(dog1);
animals.Add(dog2);


for( int i = 0; i < animals.Count; i++ )
{
    if(animals[i].Type == EnumType.CAT)
    {
        animals[i].PrintAnimal();
        ((Cat)animals[i]).Eat("fish");

    }
    else if (animals[i].Type == EnumType.DOG)
    {
        animals[i].PrintAnimal();
        ((Dog)animals[i]).Bark();
    }
    else
    {
        Console.WriteLine("You entered wrong type of animal...");
    }
}


Console.ReadLine();

