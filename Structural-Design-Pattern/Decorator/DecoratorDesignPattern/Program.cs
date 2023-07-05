
using DecoratorDesignPattern;

//Create an instance of Concrete Component BMWCar
ICar bmwCar1 = new BmwCar();
//Calling the ManufactureCar method will create the BMWCar without an engine
bmwCar1.ManufactureCar();
Console.WriteLine(bmwCar1 + "\n");

DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
carWithDieselEngine.ManufactureCar();
Console.WriteLine();

ICar bmwCar2 = new BmwCar();
PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
carWithPetrolEngine.ManufactureCar();