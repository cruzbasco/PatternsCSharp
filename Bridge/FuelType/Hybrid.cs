using Bridge.FuelType;

namespace Bridge
{
    internal class Hybrid : IFuelType
    {
        public int Efficiency()
        {
            return 160;
        }
    }
}