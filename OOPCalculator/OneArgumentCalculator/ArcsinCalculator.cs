using System;

namespace OOPCalculator
{
    public class ArcsinCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }

    }
}