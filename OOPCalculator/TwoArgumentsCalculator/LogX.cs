using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class LogX: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument <= 0 || secondArgument<=1)
            {
                throw new Exception("Нельзя по правилам");
            }
            return Math.Log(firstArgument, secondArgument);
        }
    }
}