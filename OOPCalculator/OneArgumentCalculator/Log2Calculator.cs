using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class Log2Calculator: IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates base 2 logarithm
        /// </summary>
        /// <param name="firstArgument">Number</param>
        /// <returns>Result</returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("Нельзя по правилам");
            }
            return Math.Log(firstArgument,2);
        }
    }
}