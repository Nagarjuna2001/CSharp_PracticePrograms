using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    //Product A2 class
    public class SamsungGalaxy : ISmartPhone
    {
        public SamsungGalaxy() { }

        public string GetModelDetails()
        {
            return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
