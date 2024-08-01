namespace FactoryMethod
{
    internal class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platimun";
        }

        public decimal GetCrediCardLimit()
        {
            return 25000;
        }

        public decimal GetAnnualCharge()
        {
            return 2000;
        }
    }
}
