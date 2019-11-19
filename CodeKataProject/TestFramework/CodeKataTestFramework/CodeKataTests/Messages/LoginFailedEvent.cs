using Org.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKataTests.Messages
{
    public class LoginFailedEvent : IMessage
    {
        public string UserName { get; set; }
        public DateTime FailedAt { get; set; }
    }
}
