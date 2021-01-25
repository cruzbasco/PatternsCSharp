using Bridge.FuelType;
using Bridge.Transport;
using System;

namespace Bridge
{
    internal class Car : ITransport
    {
        private IFuelType fuel;

        public Car(IFuelType gasoline)
        {
            this.fuel = gasoline;
        }

        public void CalculateMaxRange()
        {
            Console.WriteLine(1 * fuel.Efficiency()) ;
        }
    }
}