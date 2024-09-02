using FactoryDesignSample.Factory;
using FactoryDesignSample.Product;

namespace FactoryDesignSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory twoWheelerFactory = new TwoWheelerFactory();
            Client twoWheelerClient = new Client(twoWheelerFactory);
            Vehicle twoWheeler = twoWheelerClient.getVehicle();
            twoWheeler.PrintVehicle();

            VehicleFactory fourWheelerFactory = new FourWheelerFactory();
            Client fourWheelerClient = new Client(fourWheelerFactory);
            Vehicle fourWheeler = fourWheelerClient.getVehicle();
            fourWheeler.PrintVehicle();
        }
    }
}
