using SimpleFactory.Factories;
using SimpleFactory.Products;
using SimpleFactory.Products.Interfaces;

// Simple Factory Design pattern
//According to Gang of Four (GoF), a factory is an object used to create other objects. In technical terms, a factory is a class with a method.
//That method creates and returns different objects based on the received input parameter.

//In simple words, if we have a superclass and n number of subclasses, and based on the data provided,
//if we have to create and return the object of one of the subclasses, then we need to use the Factory Design Pattern in C#.

//In the Factory Design pattern, we create an object without exposing the Object Creation and Initialization logic to the client,
//and the client will refer to the newly created object using a common interface.
//The basic principle behind the Factory Design Pattern is that, at run time, we get an object of a similar type based on the parameter we pass.
//So, the client will get the appropriate object and consume the object without knowing how the object is created and initialized. 

//Generally we will get the Card Type from UI.
//Here we are hardcoding the card type
var cardType = "MoneyBack";

// No factory example:

//Based of the CreditCard Type we are creating the
//appropriate type instance 
ICreditCard? cardDetails = null;
if (cardType == "MoneyBack")
    cardDetails = new MoneyBack();
else if (cardType == "Platinum")
    cardDetails = new Platinum();
else if (cardType == "Titanium")
    cardDetails = new Titanium();

// Problems that above code introduces:
// First, the Tight Coupling between the client class (Program) and Product Classes (MoneyBack, Titanium, and Platinum).
// So, when we make changes in one class, we must also make changes in the other classes.
// Secondly, suppose we add a new Credit Card.In that case, we also need to modify the client code, i.e.,
// the main method of the Program class, by adding an extra IF-ELSE Condition,
// which not only overheads the development but also the testing process.

//______________________________

// Simple factory example:
//  We can say that a factory is a place where products are created.
//  In other words, we can say that it is a centralized place for creating products. 

cardDetails = CreditCardFactory.GetCreditCard(cardType);

if (cardDetails != null)
{
    Console.WriteLine("CardType : " + cardDetails.GetCardType());
    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditCardLimit());
    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card Type");
}

//Here’s a breakdown of the typical components in a Factory Design Pattern diagram:
// Product Interface / Abstract Product: This represents the interface or abstract class defining the methods that concrete products must implement.
// In our example, it is the CreditCard Interface.
// Concrete Products: These are the classes that implement the Product interface or extend the abstract class.
// They are the actual objects that the factory will create. In our example, it is the MoneyBack, Platinum, and Titanium classes.
// Creator or Factory: This class provides the factory method to return an instance of a specific Concrete Product.
// In our example, it is the CreditCardFactory class.
// Client: The class that consumes the actual product objects. In our example, it is the Program class’s Main method.

//____________________________________________

// When Simple Factory Design pattern can be beneficial:

// Complex Creation Logic: when the creation of an object is complex and requires more than a simple instantiation.
//  The Factory pattern can encapsulate this complexity.

// Similar Object Families: When dealing with families of related of dependant objects designed to be used together,
//  you need a way to create these objects so they can easily be swapped with other families without modifying the client code.

// Subclass Selection:  When you need to support the dynamic instantiation of one or more derived classes from a common base class
//  or interface based on the input or configuration data provided.

// System Scalability: As real time applications grow, new object types can be added with minimal changes to the existing application code.
//  Factories can handle the creation logic for these new types without altering existing code, enhancing the scalability of the application.

// Conditional Object Creation: When the instantiation of an object depends on certain external conditions or configuration settings, 
//  and you want to extract these conditions from the main application logic.

// Centralized Object Management: When you need to centralize the control of object creation to ensure consistency in behaviour 
//  or configuraion among the instances that are produced.

//____________________________________________

// Problems with the Simple Factory Design patter
//If we need to add a new product(e.g., a new credit card), we need to add a new if-else condition
//in the GetCreditCard method of the CreditCardFactory class. This violates the open/closed design principle.
//We also have a tight coupling between the Factory (CreditCardFactory) and Product classes (MoneyBack, Titanium, and Platinum).
//We can overcome these problems using the Factory Method Design Pattern.

