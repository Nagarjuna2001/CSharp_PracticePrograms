using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public class SMSNotification : IMessenger
    {
        public SMSNotification() { }

        public void SendMessage()
        {
            // code to send sms
            Console.WriteLine("Notification sent through SMS");
        }
    }
}
