namespace Decorator
{
    //The following Concrete Decorator class will add Vegetables to the Existing Pizza
    public class VeggiePizzaDecorator : PizzaDecorator
    {
        //Pass the existing pizza object while creating the Instance of VeggiePizzaDecorator class
        //Also pass the same existing pizza object to the base class constructor
        public VeggiePizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        //Overriding the MakePizza method to Vegetables
        public override string MakePizza()
        {
            //First Call the Concrete Components MakePizza Method and then the AddVegetables method
            return pizza.MakePizza() + AddVegetables();
        }

        private string AddVegetables()
        {
            return ", Vegetables added";
        }
    }
}
