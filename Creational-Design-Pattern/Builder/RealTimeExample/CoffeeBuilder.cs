namespace RealTimeExample;

public class CoffeeBuilder : BeverageBuilder
{
    public override void SetWater()
    {
        Console.WriteLine("Step 1 : Boiling water");
        beverage.Water = 40;
    }

    public override void SetMilk()
    {
        Console.WriteLine("Step 2 : Adding milk");
        beverage.Milk = 50;
    }

    public override void SetSugar()
    {
        Console.WriteLine("Step 3 : Adding Sugar");
        beverage.Sugar = 10;
    }

    public override void SetPowderQuantity()
    {
        Console.WriteLine("Step 4 : Adding 15 Grams of coffee powder");
        beverage.PowderQuantity = 15;
    }

    public override void SetBeverageType()
    {
        Console.WriteLine("Coffee");
        beverage.BeverageName = "Coffee";
    }
}
