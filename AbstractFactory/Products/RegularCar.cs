using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularCar Details..");
        }
    }
}
