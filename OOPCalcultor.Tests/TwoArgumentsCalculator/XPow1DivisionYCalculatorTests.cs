using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class XPow1DivisionYCalculatorTests

    {
        [TestCase(1, 2, 1)]

        [TestCase(1, 1, 1)]

        [TestCase(4, 2, 2)]

        public void CalculateTest(double firstValue, double secondValue, double expected)

        {
            var calculator = new XPow1DivisionYCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
