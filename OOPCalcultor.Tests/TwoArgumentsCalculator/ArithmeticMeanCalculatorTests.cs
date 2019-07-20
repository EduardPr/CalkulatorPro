using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class ArithmeticMeanCalculatorTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(3, 3, 3)]
        [TestCase(4, 4, 4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new ArithmeticMeanCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}