namespace FactoryMethod
{
    internal class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }
        public decimal GetCrediCardLimit()
        {
            return 35000;
        }

        public decimal GetAnnualCharge()
        {
            return 2500;
        }
    }
}
