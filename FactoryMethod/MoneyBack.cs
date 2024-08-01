namespace FactoryMethod
{
    internal class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public decimal GetCrediCardLimit()
        {
            return 15000;
        }

        public decimal GetAnnualCharge()
        {
            return 500;
        }

    }
}
