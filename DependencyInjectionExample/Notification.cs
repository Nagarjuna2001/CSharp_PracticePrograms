using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public class Notification
    {
        private IMessenger iMessenger;
        public Notification(IMessenger NotificationType)
        {
            iMessenger = NotificationType;
           
        }

        public void Notify()
        {
            iMessenger.SendMessage();
        }
    }
}
