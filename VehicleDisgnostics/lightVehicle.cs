using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
    class lightVehicle : VehicleDecorator
    {
        Vehicle vehicle;
      public lightVehicle(Vehicle vehicle) : base(vehicle)
        {
        this. vehicle=vehicle;
     }

      public  override    String GetDescription()
       {
        return base .GetDescription() + "- Light Vehicle";
       }
    

    }
}
