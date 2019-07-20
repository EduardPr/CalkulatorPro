using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class GeometricMeanCalculatorTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(3, 4, 6)]
        [TestCase(4, 4, 8)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new GeometricMeanCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}