namespace OOPCalculator.TwoArgumentsCalculator
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The choice of the maximum argument of two
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument > secondArgument)
            {
                return firstArgument;
            }
            return secondArgument;

        }
    }
}