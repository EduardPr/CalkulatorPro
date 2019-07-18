using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class XPowYCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);

        }
    }
}