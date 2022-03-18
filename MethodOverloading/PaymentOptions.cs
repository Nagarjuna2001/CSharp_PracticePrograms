using System;

//The payment option on any E-commerce website has options like net banking, COD, Debit card etc.
//Which means the payment method is overloaded several times to perform payment function in various ways.

namespace MethodOverloading
{
    public class PaymentOptions
    {
        public PaymentOptions() { }

        static void Main(string[] args)
        {
            PaymentOptions.DisplayPaymentOptions();

            Console.WriteLine("Please choose the payment option to proceed : ");
            int UserSelectedOption = int.Parse(Console.ReadLine());

            while (UserSelectedOption < 1 || UserSelectedOption > 3) 
            { 
                Console.WriteLine("Invalid Option selected. Please choose a valid option");
                UserSelectedOption = int.Parse(Console.ReadLine());
            }

            PaymentProcessingPortal paymentProcessingObject = new PaymentProcessingPortal();

            switch (UserSelectedOption)
            {
                case 1:
                    {
                        paymentProcessingObject.InvokeProcessingThroughCOD();
                        break;
                    }
                case 2:
                    {
                        paymentProcessingObject.InvokeProcessingThroughNetBanking();
                        break;
                    }
                case 3:
                    {
                        paymentProcessingObject.InvokeProcessingThroughDebitCard();
                        break;
                    }
            }
        }

        private static void DisplayPaymentOptions()
        {
            Console.WriteLine("Choose 1 for payment using Cash on Delivery \nChoose 2 for payment using Net Banking \nChoose 3 for payment using Debit card\n\n");
        }
    }
}
