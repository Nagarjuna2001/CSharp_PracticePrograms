using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public class PanCard
    {
        private PanCard() { }

        private static readonly object _lock = new object();
        private static PanCard PanCardInstance = null;
        public int PanCardNumber = 123456;
            
        public static PanCard GetInstance()
        {
            lock (_lock)
            {
                return (PanCardInstance == null) ? new PanCard() : PanCardInstance;
                /*if (PanCardInstance == null)
                {
                    PanCardInstance = new PanCard();
                }

                return PanCardInstance;*/
            }
        }
        public int GetPanCardNumber()
        {
            return PanCardNumber;
        }
    }
}
