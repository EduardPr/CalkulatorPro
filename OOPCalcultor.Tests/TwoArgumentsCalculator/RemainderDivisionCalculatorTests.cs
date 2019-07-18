using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class RemainderDivisionCalculatorTests
    {
        [TestCase(1, 2, 1)]
        [TestCase(1, 3, 1)]
        [TestCase(2, 5, 2)]

        public void CalculateTest(double firstValue, double secondValue, double expected)

        {
            var calculator = new RemainderDivisionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}