using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
     class MessageSubscriberOne : IObserver
    {
        public void update(Message m)
        {
            Console.WriteLine("MessageSubscriberOne :: " + m.getMessageContent());
        }
    }
}
