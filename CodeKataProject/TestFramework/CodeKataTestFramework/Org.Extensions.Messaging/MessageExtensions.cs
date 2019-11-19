using Newtonsoft.Json;
using Org.Messaging;
using System.Text;

namespace Org.Extensions.Messaging
{
    /// <summary>
    /// 
    /// </summary>
    public static class MessageExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Envelope Wrap(this IMessage message)
        {
            var json = JsonConvert.SerializeObject(message);
            return new Envelope
            {
                Subject = message.GetType().FullName,
                Body = Encoding.Unicode.GetBytes(json)
            };
        }
    }
}
