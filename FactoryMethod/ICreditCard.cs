namespace FactoryMethod
{
    public interface ICreditCard
    {
        string GetCardType();
        decimal GetCrediCardLimit();
        decimal GetAnnualCharge();
    }
}
