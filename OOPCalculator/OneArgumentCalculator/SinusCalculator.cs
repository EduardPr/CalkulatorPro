using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class SinusCalculator: IOneArgumentCalculator

    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}