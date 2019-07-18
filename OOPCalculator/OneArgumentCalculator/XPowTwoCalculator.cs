using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class XPowTwoCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}