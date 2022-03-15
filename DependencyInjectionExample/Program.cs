using System;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification notification = new Notification(new EmailNotification());
            notification.Notify();
        }
    }
}
