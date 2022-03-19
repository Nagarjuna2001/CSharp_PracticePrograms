using System;

namespace Inheritance
{
   /*The basic purpose of using Mobile phone is communication. Several brands of mobile phones are 
     using this basic functionality by extending/inheriting the MobilePhone class functionality and adding their own new 
     features to their respective brands.*/
    public class MobilePhone
    {
        public MobilePhone(string message)
        {
            Console.WriteLine($"{message} extending Mobile Phone functionality");
        }
        public void CommunicationFacility()
        {
            //Business logic to provide communication through phone calls, messages etc.
            Console.WriteLine("Communication facility provided through phone calls, messages etc.");
        }

        public void CameraFeaturesProvidedByMobile()
        {
            Console.WriteLine("Features related to camera are present here.");
        }
    }
}
