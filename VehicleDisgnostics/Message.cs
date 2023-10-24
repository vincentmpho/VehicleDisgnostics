using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
     class Message
    {
        public  String messageContent;
     
    public Message(String m)
        {
            this.messageContent = m;
        }

        public String getMessageContent()
        {
            return messageContent;
        }
    }
}
