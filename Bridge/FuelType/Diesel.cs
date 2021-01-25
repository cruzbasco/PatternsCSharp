using Bridge.FuelType;

namespace Bridge
{
    internal class Diesel : IFuelType
    {
        public int Efficiency()
        {
            return 250;
        }
    }
}