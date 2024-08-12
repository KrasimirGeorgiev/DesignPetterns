// The Prototype Design Pattern specifies the kind of objects to create using a prototypical instance
// and creates new object by copying this prototype.

// This pattern is useful when the creation of an object is time-consuming or complex in terms of resources.
// In stead of going through the costly process of creating a fresh object from scratch, an existing instance serves as a prototype,
// and new objects can be created by copying this prototype.

using Prototype;

// This is one way to make a deep copy - every reference variable type should have the method GetClone and use MemberwiseClone to copy the the values and pass them up the chain
Employee emp1 = new Employee
{
    Name = "Kristopher",
    Department = "IT",
    ContactInfo = new ContactInfo() { Address = "BBSR"}
};

var emp2 = emp1.GetClone();
emp2.Name = "Jim";
emp2.ContactInfo.Address = "New York";

Console.WriteLine($"Employee 1: {emp1.Name} lives in {emp1.ContactInfo.Address}");
Console.WriteLine($"Employee 2: {emp2.Name} lives in {emp2.ContactInfo.Address}");

// Prototype pattern is all about the cloning. It's important to know the difference between deep and shallow copy
// Shallow copy will only copy the value types of a class and copy the address of the reference types
// Deep copy both the value and the reference types.

// There are different ways to perform a deep copy:
// One of them we showed in this example using memberwise clone for each class we want to clone and for all the classes they contain ( and so on)
//  The Prototype pattern puts the responsibility of copying on the object to be copied. This is a great example of that. 
// There are also other methods to perform a deep clone, but we should be mindfull of the above and try to keep the responsibility
//  of copying on the object. Other examples of ways to perform deep copy are using the IClonable interface, JSON or XML Serialization,
//  Data contract Serialization - Using the [DataContract] [DataMember] attributes, Deep copy with reflection, Deep copy with Expression Trees,
//  Deep copy with third party libraries like - AutoMapper, FastDeepCloner, DeepCopy, JSON.NET