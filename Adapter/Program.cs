using System;
using System.Collections.Generic;
using Adapter.Adapter;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // do some stuff here

            IAdapter adapter = new LegacyCalculatorAdapter();

            var products = new List<Products>()
            {
                new Products(),
                new Products(),
                new Products(),
                new Products(),

            };

            int totalFee = adapter.Calculate(products);



        }
    }


}
