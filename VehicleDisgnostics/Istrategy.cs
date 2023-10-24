using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
     interface Istrategy
    {
      void doOperation(List<Vehicle_> lst, Vehicle_ v);
    }
}
