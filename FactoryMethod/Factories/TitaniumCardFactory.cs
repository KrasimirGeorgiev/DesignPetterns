using FactoryMethod.Products;
using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Factories
{
    public class TitaniumCardFactory : CreditCardFactory
    {
        protected override ICreditCard MakeCreditCard()
        {
            return new Titanium();
        }
    }
}