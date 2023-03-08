namespace RealTimeExample;

public class Beverage
{
    public int Water { get; set; }
    public int Milk { get; set; }
    public int Sugar { get; set; }
    public int PowderQuantity { get; set; }
    public string BeverageName { get; set; }

    public void ShowBeverage()
    {
        Console.WriteLine($"Hot {BeverageName} [{Water} ml of water, {Milk} ml of milk, {Sugar} gm of sugar, {PowderQuantity} gm of {BeverageName}]");
    }
}
