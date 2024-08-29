// Decorator design pattern allows us to dynamicaly add new functionalities to an exising object without altering
//  or modifying it's structure, and this desing pattern acts as a wrapper to the existing class. That means the 
//  decorator design pattern dynamically changes the functionality of an object at runtime without impacting
//  the existing functionality of the object. In short the pattern adds aditional functionalities to an object by wrapping it.
//  A decorator is an object that adds features to another object.

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of Concrete Component
            PlainPizza plainPizzaObj = new PlainPizza();
            //Calling the MakePizza method will create the pizza without chicken and vegetables
            string plainPizza = plainPizzaObj.MakePizza();
            Console.WriteLine(plainPizza);
            //Adding Chicken to the Plain Pizza
            //Create an instance PizzaDecorator class and 
            //pass existing plainPizzaObj as a parameter to the Constructor which we want to decorate
            PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizzaObj);
            //Calling the MakePizza Method using the chickenPizzaDecorator object will add Chicken to the existing Plain Pizza
            string chickenPizza = chickenPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + chickenPizza + "' using ChickenPizzaDecorator");
            //The Process is the same for adding vegetables to the existing pizza
            VeggiePizzaDecorator vegPizzaDecorator = new VeggiePizzaDecorator(plainPizzaObj);
            string vegPizza = vegPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + vegPizza + "' using VegPizzaDecorator");
            Console.Read();
        }
    }
}