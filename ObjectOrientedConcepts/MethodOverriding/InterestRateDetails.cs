using System;

namespace MethodOverriding
{
    public class InterestRateDetails
    {
        static void Main(string[] args)
        {
            SBI StateBankInterestInfo = new SBI();
            Console.WriteLine("Interest rate given by SBI Bank is "+StateBankInterestInfo.GetInterestRate());


            Axis AxisBankInterestInfo = new Axis();
            Console.WriteLine("Interest rate given by Axis Bank is " + AxisBankInterestInfo.GetInterestRate());

            ICICI ICICIBankInterestInfo = new ICICI();
            Console.WriteLine("Interest rate given by ICICI Bank is "+ ICICIBankInterestInfo.GetInterestRate());
        }
    }
}
