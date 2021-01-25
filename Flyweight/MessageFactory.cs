using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class MessageFactory
    {
        Dictionary<string, IMessage> messages = new();

        public IMessage GetMessage(string messageType)
        {
            IMessage result = null;

            if (messages.ContainsKey(messageType))
                result = messages[messageType];
            else
            {
                result = messageType switch
                {
                    "doubleload" => new DoubleLoadMessage(),
                    "weekend" => new WeekendMessage(),
                    "warning" => new WarningMessage(),
                    _ => throw new NotImplementedException()
                };

                messages.Add(messageType, result);
            }

            return result;
        }

    }
}
