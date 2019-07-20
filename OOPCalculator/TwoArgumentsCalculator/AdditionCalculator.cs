namespace OOPCalculator.TwoArgumentsCalculator
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Addition of the first and second argument
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;

        }
    }
}