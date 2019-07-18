namespace OOPCalculator.TwoArgumentsCalculator
{
    public class SubtractionCalculator: ITwoArgumentsCalculator

    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;

        }
    }
}