using SimpleFactory.Products.Interfaces;

namespace SimpleFactory.Products
{
    internal class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public decimal GetCreditCardLimit()
        {
            return 15000;
        }

        public decimal GetAnnualCharge()
        {
            return 500;
        }

    }
}
