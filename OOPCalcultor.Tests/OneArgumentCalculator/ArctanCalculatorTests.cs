using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class ArctanCalculatorTests
    {
        [TestCase(1, 0.7853)]
        [TestCase(-1, -0.7853)]
        [TestCase(0.5, 0.4636)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArctanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}