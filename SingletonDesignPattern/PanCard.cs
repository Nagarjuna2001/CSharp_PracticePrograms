﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public class PanCard
    {
        private PanCard() { }

        private static readonly object _lock = new object();
        private static PanCard PanCardInstance = null;

        public static PanCard GetInstance()
        {
            lock (_lock)
            {
                if (PanCardInstance == null)
                {
                    PanCardInstance = new PanCard();
                }

                return PanCardInstance;
            }
        }
    }
}
