using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesignSample.Product;

namespace FactoryDesignSample.Factory
{
    public abstract class VehicleFactory
    {
        public abstract Vehicle CreateVehicle();
    }
}
