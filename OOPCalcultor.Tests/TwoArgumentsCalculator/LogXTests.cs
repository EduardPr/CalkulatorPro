using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class LogXTests
    {
        [TestCase(1, 2, 0)]
        [TestCase(2, 2, 1)]
        [TestCase(4, 2, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new LogX();
            var actualResult = calculator.Calculate(firstValue,secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}