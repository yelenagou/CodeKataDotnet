using System;
using System.Collections.Generic;
using System.Text;

namespace Org.Messaging
{
   public interface IMessageQueue
   {
        void Publish(Envelope message);
   }
}
