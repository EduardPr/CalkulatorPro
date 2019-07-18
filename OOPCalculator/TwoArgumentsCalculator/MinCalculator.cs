namespace OOPCalculator.TwoArgumentsCalculator
{
    public class MinCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < secondArgument) return firstArgument;
            else return secondArgument;

        }

    }
}