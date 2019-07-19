using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class EPowerXTests

    {
        [TestCase(1, 2.7182)]

        [TestCase(2, 7.3890)]

        [TestCase(3, 20.0855)]

        public void CalculateTest(double firstValue, double expected)

        {
            var calculator = new EPowerX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}