namespace DecoratorDesignPattern;

public class BmwCar : ICar
{
    private string CarName { get; set; } = "BMW";
    public string CarBody { get; set; }
    public string CarDoor { get; set; }
    public string CarWheels { get; set; }
    public string CarGlass { get; set; }
    public string Engine { get; set; }

    public override string ToString()
    {
        return $"BMWCar [CarName={CarName}, CarBody={CarBody}, CarDoor={CarDoor}, CarWheels={CarWheels}, CarGlass={CarGlass}, Engine={Engine}]";
    }

    public ICar ManufactureCar()
    {
        CarBody = "carbon fiber material";
        CarDoor = "4 car doors";
        CarWheels = "4 MRF wheels";
        CarGlass = "6 car glasses";
        return this;
    }
}
