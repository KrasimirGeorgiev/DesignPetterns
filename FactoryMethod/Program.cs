using FactoryMethod;
using FactoryMethod.Factories;

// Method factory is a creational design pattern
// Defines an interface for creating a single object, but let subclasses decide which class to instantiate. 
// It let's a class defer instantiation to subclasses.

ICreditCard creditCard = new PlatinumCardFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditCardLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}