using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class MinCalculatorTests
    {
        [TestCase(1, 2, 1)]
        [TestCase(3, 2, 2)]
        [TestCase(4, 2, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MinCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}