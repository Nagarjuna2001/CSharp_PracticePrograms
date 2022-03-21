using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    //Product B2 class
    public class SamsungGuru : INormalPhone
    {
        public SamsungGuru() { }

        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
