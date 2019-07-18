using System;

namespace OOPCalculator
{
    public class ArccosCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }

    }
}