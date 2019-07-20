using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class LnCalculatorTests
    {
        [TestCase(1, 0.0000)]
        [TestCase(2, 0.6931)]
        [TestCase(3, 1.0986)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new LnCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}