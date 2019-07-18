using System;

namespace OOPCalculator
{
    public class Log10Calculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument,10);
        }
    }
}