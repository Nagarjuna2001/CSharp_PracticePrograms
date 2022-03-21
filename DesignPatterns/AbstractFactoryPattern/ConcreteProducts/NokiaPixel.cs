using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class NokiaPixel : ISmartPhone
    {
        //Product A1 class
        public NokiaPixel() { }

        public string GetModelDetails()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
