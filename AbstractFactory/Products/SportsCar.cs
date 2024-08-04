using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsCar Details..");
        }
    }
}
