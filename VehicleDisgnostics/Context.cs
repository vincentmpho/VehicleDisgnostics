using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
    class Context
    {
        private Istrategy strategy;

        public Context(Istrategy strategy)
        {
            this.strategy = strategy;
        }

        public void executeStrategy(List<Vehicle_> vehicles, Vehicle_ v)
        {
            strategy.doOperation(vehicles, v);
        }
    }
}
