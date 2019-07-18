using System;

namespace OOPCalculator
{
    public class XPow1DivisionYCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 1/secondArgument);

        }
    }
}