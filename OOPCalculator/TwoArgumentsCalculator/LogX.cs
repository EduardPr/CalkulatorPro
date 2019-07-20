using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class LogX: ITwoArgumentsCalculator
    {
        /// <summary>
        /// Return the logarithm of the specified number with the specified base
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument <= 0 || secondArgument<=1)
            {
                throw new Exception("Нельзя по правилам");
            }
            return Math.Log(firstArgument, secondArgument);
        }
    }
}