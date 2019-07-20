namespace OOPCalculator.TwoArgumentsCalculator
{
    public interface ITwoArgumentsCalculator
    {
        /// <summary>
        /// Interface two arguments calculator
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        double Calculate(double firstArgument, double secondArgument);
    }
}