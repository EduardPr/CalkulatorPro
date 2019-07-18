using System;

namespace OOPCalculator
{
    public class TanCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }

    }
}