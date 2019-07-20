using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class LnCalculator: IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates logarithm based on the exponent
        /// </summary>
        /// <param name="firstArgument">Number</param>
        /// <returns>Result</returns>
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