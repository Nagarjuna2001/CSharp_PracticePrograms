﻿using System;


namespace DecoratorPattern.Component
{
    // Component
    public abstract class Car
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double GetCarPrice();
    }
}
