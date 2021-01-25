using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            //var phones = GetPhones(5_000_000);
            string[] messageTypes = new string[] { "doubleload", "weekend", "warning" };
            var messageFactory = new MessageFactory();
            var rdn = new Random();

            int count = 0;

            //for (int i = 0; i < 5_000_000; i++)
            //{
            //    IMessage message = messageFactory.GetMessage(messageTypes[rdn.Next(3)]);

            //    count++;
            //}


            for (int i = 0; i < 5_000_000; i++)
            {
                var message = GetMessage(messageTypes[rdn.Next(3)]);

                count++;
            }


            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static IMessage GetMessage(string messageType)
        {
            return messageType switch
            {
                "doubleload" => new DoubleLoadMessage(),
                "weekend" => new WeekendMessage(),
                "warning" => new WarningMessage(),
                _ => throw new NotImplementedException()
            };
        }

        static List<string> GetPhones(int amount)
        {
            List<string> phones = new();
            Random rdn = new Random();
            for (int i = 0; i < amount; i++)
            {
                var phone = $"7{rdn.Next(11, 30)}-{rdn.Next(200, 800)}{rdn.Next(10, 99)}";
                phones.Add(phone);
            }

            return phones;
        }

    }
}
