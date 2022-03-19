using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public class EmailNotification : IMessenger
    {
        public EmailNotification() { }

        public void SendMessage()
        {
            // code to send email
            Console.WriteLine("Notification sent through email");
        }
    }
}
