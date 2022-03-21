using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    //Concrete Factory 1
    public class Samsung : IMobilePhone
    {
        public Samsung() { }

        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }

        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }
    }
}
