namespace RealTimeExample
{
    internal class TeaBuilder : BeverageBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("Step 1 : Boiling water");
            beverage.Water = 50;
        }

        public override void SetMilk()
        {
            Console.WriteLine("Step 2 : Adding milk");
            beverage.Milk = 60;
        }

        public override void SetSugar()
        {
            Console.WriteLine("Step 3 : Adding Sugar");
            beverage.Sugar = 15;
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4 : Adding 20 Grams of tea powder");
            beverage.PowderQuantity = 20;
        }

        public override void SetBeverageType()
        {
            Console.WriteLine("Tea");
            beverage.BeverageName = "Tea";
        }
    }
}
