using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    //Concrete Factory 1
    public class Nokia : IMobilePhone
    {
        public Nokia() { }
        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }
    }
}
