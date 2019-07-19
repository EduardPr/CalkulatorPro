using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class Log10CalculatorTests

    {
        [TestCase(1, 0)]

        [TestCase(10, 1)]

        [TestCase(100, 2)]

        public void CalculateTest(double firstValue, double expected)

        {
            var calculator = new Log10Calculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}