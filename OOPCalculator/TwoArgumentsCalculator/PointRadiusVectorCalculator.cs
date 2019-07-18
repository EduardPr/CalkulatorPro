using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class PointRadiusVectorCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Sqrt(firstArgument* firstArgument+ secondArgument* secondArgument);
        }
    }
}