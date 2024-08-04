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
