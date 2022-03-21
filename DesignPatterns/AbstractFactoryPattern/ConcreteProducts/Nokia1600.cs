using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    //Product B1 class
    public class Nokia1600 : INormalPhone
    {
        public Nokia1600() { }

        public string GetModelDetails()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
