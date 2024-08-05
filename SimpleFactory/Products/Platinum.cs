using SimpleFactory.Products.Interfaces;

namespace SimpleFactory.Products
{
    internal class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platimun";
        }

        public decimal GetCreditCardLimit()
        {
            return 25000;
        }

        public decimal GetAnnualCharge()
        {
            return 2000;
        }
    }
}
