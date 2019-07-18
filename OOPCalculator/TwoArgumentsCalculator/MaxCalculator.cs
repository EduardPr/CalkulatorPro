namespace OOPCalculator
{
    public class MaxCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument > secondArgument) return firstArgument;
            else return secondArgument;

        }
    }
}