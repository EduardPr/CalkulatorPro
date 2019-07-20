using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class XPowTwoCalculatorTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(3, 9)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new XPowTwoCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}