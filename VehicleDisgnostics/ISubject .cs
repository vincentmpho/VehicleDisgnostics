using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
     interface ISubject 
    {
         void attach(IObserver o);
        void detach(IObserver o);
        void notifyUpdate(Message m);
    }
}
