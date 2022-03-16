using System;

//The payment option on any E-commerce website has options like net banking, COD, Debit card etc.
//Which means the payment method is overloaded several times to perform payment function in various ways.

namespace MethodOverloading
{
    public class AmazonWebsite
    {
        public AmazonWebsite() { }

        private static void PaymentProcessing()
        {
            Console.WriteLine("Oder Placed. Please pay the cash to the delivery executive. Thank you");
        }
        private static void PaymentProcessing(string Username, string password)
        {
            //Credentials are checked and processed
            Console.WriteLine("Payment processing going on through Net Banking...");
        }

        private static void PaymentProcessing(string NameOnCard, string UserDebitCardNumber, string UserDebitCardCVV)
        {
            //Credentials are checked and processed
            Console.WriteLine("Payment processing going on through debit card...");
        }

        static void Main(string[] args)
        {
            AmazonWebsite.DisplayPaymentOptions();

            Console.WriteLine("Please choose the payment option to proceed : ");
            int UserSelectedOption = int.Parse(Console.ReadLine());

            while (UserSelectedOption < 1 || UserSelectedOption > 3) 
            { 
                Console.WriteLine("Invalid Option selected. Please choose a valid option");
                UserSelectedOption = int.Parse(Console.ReadLine());
            } 

            switch (UserSelectedOption)
            {
                case 1:
                    {
                        PaymentProcessing();
                        break;
                    }
                case 2:
                    {
                        InvokeProcessingThroughNetBanking();
                        break;
                    }
                case 3:
                    {
                        InvokeProcessingThroughDebitCard();
                        break;
                    }
            }
        }

        private static void DisplayPaymentOptions()
        {
            Console.WriteLine("Choose 1 for payment using Cash on Delivery \nChoose 2 for payment using Net Banking \nChoose 3 for payment using Debit card\n\n");
        }
        
        private static void InvokeProcessingThroughNetBanking()
        {
            Console.WriteLine("Please provide your username");
            string UsernameOfUser = Console.ReadLine();
            Console.Write("Please provide your password");
            string PasswordOfUser = Console.ReadLine();

            PaymentProcessing(UsernameOfUser, PasswordOfUser);
        }

        private static void InvokeProcessingThroughDebitCard()
        {
            Console.WriteLine("Please enter the name on card");
            string NameOnCard = Console.ReadLine();
            Console.WriteLine("Please provide your DebitCard Number");
            string DebitCardNumber = Console.ReadLine();
            Console.WriteLine("Please provide your CVV");
            string CVVNumberOfDebitCard = Console.ReadLine();

            PaymentProcessing(NameOnCard, DebitCardNumber, CVVNumberOfDebitCard);
        }
    }
}
