using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public class PointDegreeCalculator: ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate the angle of a point given in Euclidean coordinates in the radial coordinate system
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Atan(secondArgument/firstArgument);
        }
    }
}