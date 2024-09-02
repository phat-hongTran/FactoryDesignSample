using FactoryDesignSample.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignSample.Factory
{
    public class TwoWheelerFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new TwoWheeler();
        }
    }
}
