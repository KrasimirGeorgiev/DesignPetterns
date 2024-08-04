using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    public class SportsBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsBike Details..");
        }
    }
}
