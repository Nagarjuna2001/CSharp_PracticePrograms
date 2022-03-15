using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public class Email
    {
        public Email()
        {
        }

        public void SendEmail()
        {
            // code to send mail
        }
    }

    public class SendNotification
    {
        private Email email;
        public SendNotification()
        {
            email = new Email();
        }

        public void PromotionalNotification()
        {
            email.SendEmail();
        }
    }
}
