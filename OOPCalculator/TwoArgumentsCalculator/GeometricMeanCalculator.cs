namespace OOPCalculator.TwoArgumentsCalculator
{
    public class GeometricMeanCalculator:ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculation of the geometric mean of two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * secondArgument) / 2;

        }
    }
}