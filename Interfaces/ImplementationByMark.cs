using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class ImplementationByMark : ISignUpPageForClient
    {
        public ImplementationByMark() { }

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
}
