namespace OOPCalculator
{
    public class ArithmeticMeanCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument) / 2;

        }
    }
}