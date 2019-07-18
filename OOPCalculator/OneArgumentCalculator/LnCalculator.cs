using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class LnCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}