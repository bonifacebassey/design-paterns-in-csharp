namespace RealTimeExample;

public abstract class BeverageBuilder
{
    protected Beverage beverage;

    public abstract void SetWater();
    public abstract void SetMilk();
    public abstract void SetSugar();
    public abstract void SetPowderQuantity();
    public abstract void SetBeverageType();

    public void CreateBeverage()
    {
        beverage = new Beverage();
    }

    public Beverage GetBeverage()
    {
        return beverage;
    }
}
