namespace FactoryMethod
{
    public interface ICreditCard
    {
        string GetCardType();
        decimal GetCreditCardLimit();
        decimal GetAnnualCharge();
    }
}
