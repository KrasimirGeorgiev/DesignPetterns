using FactoryMethod.Products;
using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Factories
{
    public class MoneyBackCardFactory : CreditCardFactory
    {
        protected override ICreditCard MakeCreditCard()
        {
            return new MoneyBack();
        }
    }
}
