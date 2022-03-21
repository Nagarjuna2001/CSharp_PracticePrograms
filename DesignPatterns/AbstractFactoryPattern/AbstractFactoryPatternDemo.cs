using System;

namespace AbstractFactoryPattern
{
    public class AbstractFactoryPatternDemo
    {
        static void Main()
        {
            try
            {
                IMobilePhone nokiaMobilePhone = FactoryCreator.getFactory("Nokia");
                MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

                Console.WriteLine("********* NOKIA **********");
                Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
                Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());
            }
            catch (Exception)
            {

            }

            try
            {
                IMobilePhone samsungMobilePhone = FactoryCreator.getFactory("Samsung");
                MobileClient samsungClient = new MobileClient(samsungMobilePhone);

                Console.WriteLine("******* SAMSUNG **********");
                Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
                Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());
            }
            catch (Exception) { }

        }
    }
}
