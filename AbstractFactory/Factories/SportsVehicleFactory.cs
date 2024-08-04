using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories
{
    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportsBike();
        }

        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }
}
