using Bridge.FuelType;

namespace Bridge
{
    internal class Gasoline : IFuelType
    {
        public int Efficiency()
        {
            return 100;
        }
    }
}