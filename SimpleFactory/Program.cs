using FactoryMethod;

//Generally we will get the Card Type from UI.
//Here we are hardcoding the card type
var cardType = "MoneyBack";

//Based of the CreditCard Type we are creating the
//appropriate type instance 
ICreditCard cardDetails = null;
if (cardType == "MoneyBack")
    cardDetails = new MoneyBack();
else if (cardType == "Platinum")
    cardDetails = new Platinum();
else if (cardType == "Titanium")
    cardDetails = new Titanium();

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


// Problems that above code introduces:
// First, the Tight Coupling between the client class (Program) and Product Classes (MoneyBack, Titanium, and Platinum).
// So, when we make changes in one class, we must also make changes in the other classes.
// Secondly, suppose we add a new Credit Card.In that case, we also need to modify the client code, i.e.,
// the main method of the Program class, by adding an extra IF-ELSE Condition,
// which not only overheads the development but also the testing process.