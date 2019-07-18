using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class PointDegreeCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Atan(secondArgument/firstArgument);
        }
    }
}