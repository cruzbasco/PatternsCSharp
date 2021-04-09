using System;
using System.Collections.Generic;
using System.Linq;

namespace Adapter.Adapter
{
    public interface IAdapter
    {
        public int Calculate(IEnumerable<Products> products);
    }

    public class LegacyCalculatorAdapter : IAdapter
    {
        public int Calculate(IEnumerable<Products> products)
        {
            var legacyCalculator = new LegacyCalculator();

            return legacyCalculator.CalculateFees(products.ToArray());
        }
    }
}
