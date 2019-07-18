using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class CtanCalculatorTests
    {
        [TestCase(1, 0.6420)]
        [TestCase(-1, -0.6420)]
        [TestCase(-2, 0.4576)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new CtanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}