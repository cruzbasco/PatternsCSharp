namespace CompositePattern.Maths
{
    public class SimpleExpression : IMathExpression
    {
        private readonly int number;

        public SimpleExpression(int number)
        {
            this.number = number;
        }
        public int Calculate()
        {
            return number;
        }
    }
}