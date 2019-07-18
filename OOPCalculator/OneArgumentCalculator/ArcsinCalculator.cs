using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class ArcsinCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }

    }
}