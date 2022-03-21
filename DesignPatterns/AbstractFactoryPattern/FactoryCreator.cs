using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class FactoryCreator
    {
        public FactoryCreator() {  }

        public static IMobilePhone getFactory(String choice)
        {
            if (choice == "Nokia")
            {
                return new Nokia();
            }
            else if (choice == "Samsung")
            {
                return new Samsung();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
