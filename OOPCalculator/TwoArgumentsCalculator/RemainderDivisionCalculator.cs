namespace OOPCalculator.TwoArgumentsCalculator
{
    public class RemainderDivisionCalculator:ITwoArgumentsCalculator

    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument%secondArgument;

        }
    }
}