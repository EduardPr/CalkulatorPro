using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class TanCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }

    }
}