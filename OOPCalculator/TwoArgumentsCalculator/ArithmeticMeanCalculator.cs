namespace OOPCalculator.TwoArgumentsCalculator
{
    public class ArithmeticMeanCalculator:ITwoArgumentsCalculator
    {
        /// <summary>
        /// The calculation of the arithmetic average of two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument) / 2;

        }
    }
}