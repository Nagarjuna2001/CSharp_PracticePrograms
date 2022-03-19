using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloading
{
    public class PaymentProcessingPortal
    {
        public PaymentProcessingPortal() { }

        private void ProcessPayment()
        {
            Console.WriteLine("Oder Placed. Please pay the cash to the delivery executive. Thank you");
        }
        private void ProcessPayment(string Username, string password)
        {
            //Credentials are checked and processed
            Console.WriteLine("Payment processing going on through Net Banking...");
        }

        private void ProcessPayment(string NameOnCard, string UserDebitCardNumber, string UserDebitCardCVV)
        {
            //Credentials are checked and processed
            Console.WriteLine("Payment processing going on through debit card...");
        }




        public void InvokeProcessingThroughCOD()
        {
            ProcessPayment();
        }
        public void InvokeProcessingThroughNetBanking()
        {
            Console.WriteLine("Please provide your username");
            string UsernameOfUser = Console.ReadLine();
            Console.Write("Please provide your password");
            string PasswordOfUser = Console.ReadLine();

            ProcessPayment(UsernameOfUser, PasswordOfUser);
        }
        public void InvokeProcessingThroughDebitCard()
        {
            Console.WriteLine("Please enter the name on card");
            string NameOnCard = Console.ReadLine();
            Console.WriteLine("Please provide your DebitCard Number");
            string DebitCardNumber = Console.ReadLine();
            Console.WriteLine("Please provide your CVV");
            string CVVNumberOfDebitCard = Console.ReadLine();

            ProcessPayment(NameOnCard, DebitCardNumber, CVVNumberOfDebitCard);
        }
    }
}
