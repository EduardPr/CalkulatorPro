using System;

namespace OOPCalculator
{
    public class EPowerX: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}