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

