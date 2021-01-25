using Bridge.FuelType;
using Bridge.Transport;
using System;

namespace Bridge
{
    internal class Train : ITransport
    {
        private IFuelType fuel;

        public Train(IFuelType electric)
        {
            this.fuel = electric;
        }

        public void CalculateMaxRange()
        {
            Console.WriteLine(1.4 * fuel.Efficiency());
        }
    }
}