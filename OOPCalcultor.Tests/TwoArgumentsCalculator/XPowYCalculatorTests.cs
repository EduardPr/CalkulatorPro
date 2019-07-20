using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class XPowYCalculatorTests
    {
        [TestCase(1, 2, 1)]
        [TestCase(1, 1, 1)]
        [TestCase(4, 2, 16)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XPowYCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
