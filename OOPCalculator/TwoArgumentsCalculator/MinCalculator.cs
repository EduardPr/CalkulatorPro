namespace OOPCalculator.TwoArgumentsCalculator
{
    public class MinCalculator: ITwoArgumentsCalculator
    {
        /// <summary>
        /// The choice of the minimum argument of two
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < secondArgument) return firstArgument;
            else return secondArgument;

        }

    }
}