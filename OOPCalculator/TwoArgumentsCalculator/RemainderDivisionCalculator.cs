namespace OOPCalculator.TwoArgumentsCalculator
{
    public class RemainderDivisionCalculator:ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculating the remainder of dividing two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument%secondArgument;
        }
    }
}