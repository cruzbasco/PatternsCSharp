using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public interface IMessage
    {

        string Title { get; }
        string Message { get; }
        void SendMessage(string phone);
    }

    public class DoubleLoadMessage : IMessage
    {
        private readonly string _title;
        private readonly string _message;

        public string Title => _title;

        public string Message => _message;


        public DoubleLoadMessage()
        {
            _title = "Doble Load";
            _message = "pay X and recieve 2X";
        }

        public void SendMessage(string phone)
        {
            Console.WriteLine($"\nSend to: {phone} \n {_title} - {_message}");
        }
    }

    public class WeekendMessage : IMessage
    {
        private readonly string _title;
        private readonly string _message;

        public string Title => _title;

        public string Message => _message;


        public WeekendMessage()
        {
            _title = "Weekend";
            _message = "use facebook, twitter at no cost";
        }

        public void SendMessage(string phone)
        {
            Console.WriteLine($"\nSend to: {phone} \n {_title} - {_message}");
        }
    }

    public class WarningMessage : IMessage
    {
        private readonly string _title;
        private readonly string _message;

        public string Title => _title;

        public string Message => _message;


        public WarningMessage()
        {
            _title = "Warning";
            _message = "service cut for non-payment";
        }

        public void SendMessage(string phone)
        {
            Console.WriteLine($"\nSend to: {phone} \n {_title} - {_message}");
        }
    }        
}
