namespace AbstractFactoryDesignPattern;

public class SeaAnimalFactory : AnimalFactory
{
    public override IAnimal GetAnimal(string animalType)
    {
        if (animalType.Equals("Shark"))
        {
            return new Shark();
        }
        else if (animalType.Equals("Octopus"))
        {
            return new Octopus();
        }
        else
            return null;
    }
}
