using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class XPowYCalculator: ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculating X to degree Y
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);

        }
    }
}