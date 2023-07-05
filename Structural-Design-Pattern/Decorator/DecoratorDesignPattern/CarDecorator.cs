namespace DecoratorDesignPattern;

public abstract class CarDecorator : ICar
{
    protected ICar car;

    protected CarDecorator(ICar car)
    {
        this.car = car;
    }

    public virtual ICar ManufactureCar()
    {
        return car.ManufactureCar();
    }
}
