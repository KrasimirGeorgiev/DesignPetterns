using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories
{
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }

        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
}
