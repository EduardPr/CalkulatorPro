using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
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