using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class TanCalculatorTests
    {
        [TestCase(1, 1.5574)]
        [TestCase(4, 1.1578)]
        [TestCase(7, 0.8714)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}