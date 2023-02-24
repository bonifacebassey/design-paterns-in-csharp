using NonFactoryDesignPattern;

// Normally, we will get the Card Type from UI
string cardType = "MoneyBack";

ICreditCard card = null;

if (cardType == "MoneyBack")
{
    card = new MoneyBack();
}
else if (cardType == "Titanium")
{
    card = new Titanium();
}
else if (cardType == "Platinum")
{
    card = new Platinum();
}

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



/* Problem of the above implementation:
 * 1. There is a tight coupling between this class and product classes (MoneyBack, Titanium, and Platinum) classes.
 * 2. A new Credit Card will mean modifying the Main method by adding an extra if-else.
 * 
 * These problems can be solved by using the factory design pattern.
 */