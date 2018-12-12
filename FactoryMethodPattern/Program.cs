using FactoryMethodPattern.Interfaces;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Factory Method Pattern example by 1400.");

            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            Console.ReadLine();
        }
    }
}
