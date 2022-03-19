using System;

namespace DependencyInjectionExample
{
    public class ExerciseOnDependencyInversion
    {
        static void Main(string[] args)
        {
            Notification notification = new Notification(new EmailNotification());
            notification.Notify();
        }
    }
}
