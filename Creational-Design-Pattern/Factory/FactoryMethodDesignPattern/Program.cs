using FactoryMethodDesignPattern;

ICreditCard creditCard = new PlatinumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine($"Card Type: {creditCard.GetCardType()}");
    Console.WriteLine($"Credit Limit: {creditCard.GetCreditLimit()}");
    Console.WriteLine($"Annual Charge: {creditCard.GetAnnualCharge()}");
}

creditCard = new MoneyBackFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine($"\nCard Type: {creditCard.GetCardType()}");
    Console.WriteLine($"Credit Limit: {creditCard.GetCreditLimit()}");
    Console.WriteLine($"Annual Charge: {creditCard.GetAnnualCharge()}");
}

creditCard = new TitaniumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine($"\nCard Type: {creditCard.GetCardType()}");
    Console.WriteLine($"Credit Limit: {creditCard.GetCreditLimit()}");
    Console.WriteLine($"Annual Charge: {creditCard.GetAnnualCharge()}");
}

if (creditCard == null)
{
    Console.WriteLine("Invalid Card Type");
}