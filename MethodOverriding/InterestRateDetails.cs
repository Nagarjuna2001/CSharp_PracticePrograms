using System;

namespace MethodOverriding
{
    class ReserveBankOfIndia
    {
        public virtual float GetInterestRate()
        {
            return 7.0f;
        }
    }
    class SBI : ReserveBankOfIndia
    {
        public override float GetInterestRate()
        {
            return 7.5f;
        }
    }

    class ICICI : ReserveBankOfIndia
    {
        public override float GetInterestRate()
        {
            return 8.5f;
        }
    }

    class Axis : ReserveBankOfIndia
    {
      
    }
    class InterestRateDetails
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
