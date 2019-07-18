namespace OOPCalculator.TwoArgumentsCalculator
{
    public class GeometricMeanCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * secondArgument) / 2;

        }
    }
}