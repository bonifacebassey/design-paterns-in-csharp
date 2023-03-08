
using RealTimeExample;

Beverage beverage;
BeverageDirector beverageDirector = new BeverageDirector();

// Construct and show Tea Beverage
TeaBuilder tea = new TeaBuilder();
beverage = beverageDirector.MakeBeverage(tea);
beverage.ShowBeverage();

Console.WriteLine("\n-------------------\n");

// Construct and show Coffee Beverage
CoffeeBuilder coffee = new CoffeeBuilder();
beverage = beverageDirector.MakeBeverage(coffee);
beverage.ShowBeverage();