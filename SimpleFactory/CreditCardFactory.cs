using FactoryMethod;

namespace SimpleFactory
{
    internal class CreditCardFactory
    {
        public static ICreditCard? GetCreditCard(string cardType)
        {
            ICreditCard? creditCard = null;
            if (cardType == "MoneyBack")
                creditCard = new MoneyBack();
            else if (cardType == "Platinum")
                creditCard = new Platinum();
            else if (cardType == "Titanium")
                creditCard = new Titanium();

            return creditCard;
        }
    }
}
