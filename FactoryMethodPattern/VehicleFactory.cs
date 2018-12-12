﻿using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);

    }
}
