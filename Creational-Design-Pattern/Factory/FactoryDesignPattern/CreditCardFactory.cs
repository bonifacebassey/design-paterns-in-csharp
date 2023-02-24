namespace FactoryDesignPattern;

public class CreditCardFactory
{
    public static ICreditCard GetCreditCard(string cardType)
    {
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

        return card;
0    }
}
