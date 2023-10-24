using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
     abstract class VehicleDecorator : Vehicle
    {

        Vehicle vehicle = null;
        public VehicleDecorator(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public override string GetDescription()
        {
            return vehicle.GetDescription();
        }
    }
}
