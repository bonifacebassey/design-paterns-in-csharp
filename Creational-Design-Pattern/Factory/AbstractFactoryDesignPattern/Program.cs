/* The Abstract Factory Design Pattern provides a way to encapsulate a group of individual factories 
 * that have a common theme without specifying their concrete classes
 */

using AbstractFactoryDesignPattern;

IAnimal animal;
AnimalFactory animalFactory;

// Create the Sea Factory object by passing the factory type as Sea
animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
if (animalFactory != null)
{
    Console.WriteLine($"Animal Factory type : {animalFactory.GetType().Name}\n");

    // Get Octopus Animal object by passing the animal type as Octopus
    animal = animalFactory.GetAnimal("Octopus");
    Console.WriteLine($"Animal Type : {animal.GetType().Name}");
    Console.WriteLine($"{animal.GetType().Name} Speak : {animal.Speak()}\n");

    // Get Octopus Animal object by passing the animal type as Shark
    animal = animalFactory.GetAnimal("Shark");
    Console.WriteLine($"Animal Type : {animal.GetType().Name}");
    Console.WriteLine($"{animal.GetType().Name} Speak : {animal.Speak()}\n");
}

// Create Land Factory object by passing the factory type as Land
animalFactory = AnimalFactory.CreateAnimalFactory("Land");
if (animalFactory != null)
{
    Console.WriteLine("--------------------------");
    Console.WriteLine($"Animal Factory type : {animalFactory.GetType().Name}\n");

    // Get Lion Animal object by passing the animal type as Lion
    animal = animalFactory.GetAnimal("Lion");
    Console.WriteLine($"Animal Type : {animal.GetType().Name}");
    Console.WriteLine($"{animal.GetType().Name} Speak : {animal.Speak()}\n"); 

    // Get Cat Animal object by passing the animal type as Cat
    animal = animalFactory.GetAnimal("Cat");
    Console.WriteLine($"Animal Type : {animal.GetType().Name}");
    Console.WriteLine($"{animal.GetType().Name} Speak : {animal.Speak()}\n");

    // Get Cat Animal object by passing the animal type as Dog
    animal = animalFactory.GetAnimal("Dog");
    Console.WriteLine($"Animal Type : {animal.GetType().Name}");
    Console.WriteLine($"{animal.GetType().Name} Speak : {animal.Speak()}\n");
}

