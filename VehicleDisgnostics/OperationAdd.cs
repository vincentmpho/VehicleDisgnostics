using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
     class OperationAdd : Istrategy
    {
        public void doOperation(List<Vehicle_> vehicles, Vehicle_ v)
        {
            vehicles.Add(v);
        }
    }
}
