using FactoryDesignPattern;

ICreditCard card = CreditCardFactory.GetCreditCard("Platinum");

if (card != null)
{
    Console.WriteLine("CardType: " + card.GetCardType());
    Console.WriteLine("CreditLimit: " + card.GetCreditLimit());
    Console.WriteLine("AnnualCharge: " + card.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}


/*
 * Here, we create an object without exposing the object creation logic to the client 
 * and the client refers to the newly created object using a common interface (CreditCardFactory).
 * 
 * There is still a tight coupling between the CreditCardFactory and product classes (MoneyBack, Titanium, and Platinum).
 * And we still need an if-else condition for new cards in CreditCardFactory.
 * 
 * This problem can be solved by using the Factory Method Design Pattern.
 */