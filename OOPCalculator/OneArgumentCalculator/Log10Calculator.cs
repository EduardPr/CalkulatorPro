using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class Log10Calculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("Нельзя по правилам");
            }
            return Math.Log(firstArgument,10);
        }
    }
}