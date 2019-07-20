using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class MaxCalculatorTests
    {
        [TestCase(1, 2, 2)]
        [TestCase(3, 2, 3)]
        [TestCase(4, 2, 4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MaxCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}