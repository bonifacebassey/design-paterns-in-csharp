namespace FactoryMethodDesignPattern;

public interface ICreditCard
{
    public string GetCardType();

    public int GetCreditLimit();

    public int GetAnnualCharge();
}
