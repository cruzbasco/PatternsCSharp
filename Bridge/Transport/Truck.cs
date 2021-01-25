using Bridge.FuelType;
using Bridge.Transport;
using System;

namespace Bridge
{
    internal class Truck : ITransport
    {
        private readonly IFuelType _fuel;

        public Truck(IFuelType fuel)
        {
            _fuel = fuel;
        }

        public void CalculateMaxRange()
        {
            Console.WriteLine(0.85 * _fuel.Efficiency());
        }
    }
}