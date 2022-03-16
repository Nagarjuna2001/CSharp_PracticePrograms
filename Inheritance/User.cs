using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class User
    {
        static void Main(string[] args)
        {
            Iphone AppleProduct = new Iphone("Iphone");
            AppleProduct.OperatingSystemForIphones();
            AppleProduct.CommunicationFacility();

            Console.WriteLine("----------------------------");

            Oneplus OneplusProduct = new Oneplus("Oneplus");
            OneplusProduct.OperatingSystemForOneplus();
            OneplusProduct.CameraFeaturesProvidedByMobile();
        }
    }
}
