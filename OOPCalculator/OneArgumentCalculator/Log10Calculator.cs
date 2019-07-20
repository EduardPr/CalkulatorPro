using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class Log10Calculator: IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates base 10 logarithm
        /// </summary>
        /// <param name="firstArgument">Number</param>
        /// <returns>Result</returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("Нельзя по правилам");
            }
            return Math.Log(firstArgument,10);
        }
    }
}