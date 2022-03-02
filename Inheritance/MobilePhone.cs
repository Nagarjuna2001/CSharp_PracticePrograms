using System;

namespace Inheritance
{
   /*The basic purpose of using Mobile phone is communication. Several brands of mobile phones are 
     using this basic functionality by extending/inheriting the MobilePhone class functionality and adding their own new 
     features to their respective brands.*/
    class MobilePhone
    {
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

    class Iphone : MobilePhone
    {
        public void OperatingSystemForIphones()
        {
            Console.WriteLine("Operating System used in Iphones is iOS");
        }
    }

    class Oneplus : MobilePhone
    {
        public void OperatingSystemForOneplus()
        {
            Console.WriteLine("Oneplus provides Android Operating system");
        }
    }
    class User
    {
        static void Main(string[] args)
        {
            Iphone AppleProduct = new Iphone();
            AppleProduct.OperatingSystemForIphones();
            AppleProduct.CommunicationFacility();

            Oneplus OneplusProduct = new Oneplus();
            OneplusProduct.OperatingSystemForOneplus();
            OneplusProduct.CameraFeaturesProvidedByMobile();
        }
    }
}
