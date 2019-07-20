using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Division of two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)

        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstArgument / secondArgument;

        }
    }
}