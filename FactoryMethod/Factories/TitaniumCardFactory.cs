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