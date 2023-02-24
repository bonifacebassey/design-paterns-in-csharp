namespace FactoryDesignPattern;

public interface ICreditCard
{
    public string GetCardType();

    public int GetCreditLimit();

    public int GetAnnualCharge();
}
