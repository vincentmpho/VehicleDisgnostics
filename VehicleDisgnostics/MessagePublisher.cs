using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
     class MessagePublisher : ISubject
    {

         List<IObserver> observers = new List<IObserver>();
        String State = "Initial State";


        public void attach(IObserver o)
        {
            observers.Add(o);
        }


        public void detach(IObserver o)
        {
            observers.Remove(o);
        }


        public void notifyUpdate(Message m)
        {
            foreach (IObserver o in observers)
            {
                o.update(m);
            }
        }
    }
}
