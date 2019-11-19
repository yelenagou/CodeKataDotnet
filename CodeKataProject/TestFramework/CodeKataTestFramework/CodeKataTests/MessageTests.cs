using CodeKataTests.Messages;
using Moq;
using NUnit.Framework;
using Org.Extensions.Messaging;
using Org.Messaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataTests
{
    [TestFixture]
    public class MessageTests
    {
        IMessageQueue _queue;
        [SetUp]
        public void Setup()
        {
            _queue = new Mock<IMessageQueue>().Object;
        }
        [Test]
        public void LoginFailed()
        {
            var loginFailed = new LoginFailedEvent
            {
                UserName = "sixeyed",
                FailedAt = DateTime.Now
            };
            var message = loginFailed.Wrap();
            _queue.Publish(message);
            
          
        }
    }
}
