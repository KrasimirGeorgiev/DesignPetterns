using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories.Interfaces
{
    public interface IVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
    }
}
