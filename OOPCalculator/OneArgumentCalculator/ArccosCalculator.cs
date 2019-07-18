using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class ArccosCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }

    }
}