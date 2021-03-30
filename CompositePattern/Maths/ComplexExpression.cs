using CompositePattern.Finance;
using System;

namespace CompositePattern.Maths
{
    public class ComplexExpression : IMathExpression
    {
        private string operation;
        private IMathExpression leftExpression;
        private IMathExpression rightExpression;

        // left operation right

        // 2 + 3 +4 *5
        // left = 2 
        // operation = "+"
        // right = 3 * 4 + 3

        public ComplexExpression(string expression)
        {
            var (left, operation, right) = DivideExpression(expression);
            int number;

            this.operation = operation;
            leftExpression = int.TryParse(left, out number) ? new SimpleExpression(number) : (IMathExpression)new ComplexExpression(left);

            rightExpression = int.TryParse(right, out number) ? new SimpleExpression(number) : (IMathExpression)new ComplexExpression(right);
        }

        private Tuple<string, string, string> DivideExpression(string expression)
        {
            //operation = eseOperadorEncontrado;
            throw new NotImplementedException();
        }

        public int Calculate()
        {
            return operation switch
            {
                "+" => leftExpression.Calculate() + rightExpression.Calculate(),
                "-" => leftExpression.Calculate() - rightExpression.Calculate(),
                "*" => leftExpression.Calculate() * rightExpression.Calculate(),
                "/" => leftExpression.Calculate() / rightExpression.Calculate(),
                _ => throw new NotImplementedException()
            };
        }




    }

    
}