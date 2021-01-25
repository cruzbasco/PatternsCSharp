using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Maths
{
    public class Maths
    {
        IMathExpression root;

        public Maths(string expression)
        {
            // 2+5
            root = new ComplexExpression(expression);
        }

        public void CalcuteExpresion()
        {
            Console.WriteLine(root.Calculate());
        }

    }
}
