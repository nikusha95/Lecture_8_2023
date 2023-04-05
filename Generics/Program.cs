// See https://aka.ms/new-console-template for more information

using Generics;

AnimalShelter shelter = new AnimalShelter();

shelter.Shelter(new Dog());
shelter.Shelter(new Dog());
shelter.Shelter(new Dog());

AnimalShelterGeneric<Cat> catShelterGeneric = new AnimalShelterGeneric<Cat>();

catShelterGeneric.Shelter(new Cat());
Console.WriteLine();

int a = 10;
int b = 20;

Console.WriteLine($"{a}--->{b}");

Swap(ref a, ref b);

Console.WriteLine($"{a}--->{b}");

void Swap(ref int a, ref int b)
{
    int x = a;
    a = b;
    b = x;
}
