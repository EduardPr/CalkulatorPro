using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class XPow1DivisionYCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument < 0)
            {
                throw new Exception("Нельзя по правилам");
            }
            return Math.Pow(firstArgument, 1/secondArgument);

        }
    }
}