using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    class SMSNotification : IMessenger
    {
        public void SendMessage()
        {
            // code to send sms
            Console.WriteLine("Notification sent through SMS");
        }
    }
}
