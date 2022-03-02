using System;

namespace Interfaces
{
    interface IsignupPageForClient
    {
        bool PasswordVerificationLogic(string password);
        bool IsUsernameAvailable(string username);
    }

    class ImplementationByUserA : IsignupPageForClient
    {
        public bool IsUsernameAvailable(string Username)
        {
            Console.WriteLine("The logic for checking whether the Username is available in the database is provided here.");
            //return true if Username is available else return false

            return true;
        }
        public bool PasswordVerificationLogic(string passwordEnteredByUser)
        {
            //Business logic
            Console.WriteLine("Password entered by user is compared with the actual password");
            //return true if both the passwords match else return false

            return true;
        }
    }
    class WebPageUser
    {
        static void Main(string[] args)
        {
            ImplementationByUserA SignupPageImplementation = new ImplementationByUserA();
            bool UsernameVerification = SignupPageImplementation.IsUsernameAvailable("arjun123");
            bool passwordVerification = SignupPageImplementation.IsUsernameAvailable("123545");//

            if(UsernameVerification && passwordVerification)
            {
                //User is redirected to home page
            }
            else
            {
                //User is not allowed to move to the home page
            }
        }
    }
}
