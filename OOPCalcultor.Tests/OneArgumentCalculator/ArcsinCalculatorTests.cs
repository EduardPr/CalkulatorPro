using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class ArcsinCalculatorTests
    {
        [TestCase(1, 1.5707)]
        [TestCase(-1, -1.5707)]
        [TestCase(0, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArcsinCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}