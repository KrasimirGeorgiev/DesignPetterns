using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularBike Details..");
        }
    }
}
