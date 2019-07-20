using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class Log2CalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(4, 2)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Log2Calculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}