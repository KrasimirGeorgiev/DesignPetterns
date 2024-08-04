namespace FactoryMethod.Factories
{
    public class PlatinumCardFactory : CreditCardFactory
    {
        protected override ICreditCard MakeCreditCard()
        {
            return new Platinum();
        }
    }
}
