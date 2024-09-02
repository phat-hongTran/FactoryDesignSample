using FactoryDesignSample.Factory;
using FactoryDesignSample.Product;

namespace FactoryDesignSample
{
    public class Client
    {
        private Vehicle vehicle;

        public Client(VehicleFactory factory)
        {
            vehicle = factory.CreateVehicle();
        }

        public Vehicle getVehicle()
        {
            return vehicle;
        }
    }
}
