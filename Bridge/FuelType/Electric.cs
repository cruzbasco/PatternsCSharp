using Bridge.FuelType;

namespace Bridge
{
    internal class Electric : IFuelType
    {
        public int Efficiency()
        {
            return 85;
        }
    }
}