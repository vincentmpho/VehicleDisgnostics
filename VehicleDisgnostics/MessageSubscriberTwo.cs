using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
     class MessageSubscriberTwo : IObserver
    {
        public void update(Message m)
        {
            Console.WriteLine("MessageSubscriberTwo :: " + m.getMessageContent());
        }
    }
}
