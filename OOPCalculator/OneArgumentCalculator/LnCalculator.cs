using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class LnCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("Нельзя по правилам");
            }
            return Math.Log(firstArgument);
        }
    }
}