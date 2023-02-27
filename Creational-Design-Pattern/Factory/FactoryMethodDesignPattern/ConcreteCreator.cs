namespace FactoryMethodDesignPattern;

public class MoneyBackFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        return new MoneyBack();
    }
}

public class PlatinumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        return new Platinum();
    }
}

public class TitaniumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        return new Titanium();
    }
}
