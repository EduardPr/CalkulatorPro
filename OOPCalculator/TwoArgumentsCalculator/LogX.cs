using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class LogX: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}