namespace OOPCalculator.TwoArgumentsCalculator
{
    public class SubtractionCalculator: ITwoArgumentsCalculator

    {
        /// <summary>
        /// Subtract two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;

        }
    }
}