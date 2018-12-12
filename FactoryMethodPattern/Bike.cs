using System;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern
{
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }
}
