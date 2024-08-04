namespace FactoryMethod.Factories
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeCreditCard();
        public ICreditCard CreateProduct()
        {
            ICreditCard creditCard = this.MakeCreditCard();
            return creditCard;
        }
    }
}
