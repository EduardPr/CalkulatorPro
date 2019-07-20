using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class XPow1DivisionYCalculator:ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate X to degree 1 divided by Y
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument < 0)
            {
                throw new Exception("Нельзя по правилам");
            }
            return Math.Pow(firstArgument, 1/secondArgument);

        }
    }
}