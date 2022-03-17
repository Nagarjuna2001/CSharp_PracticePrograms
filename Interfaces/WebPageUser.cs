using System;

namespace Interfaces
{
    class WebPageUser
    {
        static void Main(string[] args)
        {
            ImplementationByMark SignupPageImplementation = new ImplementationByMark();
            bool UsernameVerification = SignupPageImplementation.IsUsernameAvailable("arjun123");
            bool passwordVerification = SignupPageImplementation.IsUsernameAvailable("123545");//

            if(UsernameVerification && passwordVerification)
            {
                //User is redirected to home page
                Console.WriteLine("User is directed to home page");
            }
            else
            {
                //User is not allowed to move to the home page
                Console.WriteLine("Prompt is displayed which says password incorrect");
            }
        }
    }
}
