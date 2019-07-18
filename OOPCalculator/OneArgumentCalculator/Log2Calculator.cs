using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class Log2Calculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument,2);
        }
    }
}