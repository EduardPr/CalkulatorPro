using System;

namespace OOPCalculator
{
    public class SinusCalculator: IOneArgumentCalculator

    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}