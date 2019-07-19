using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class PointRadiusVectorCalculatorTests

    {
        [TestCase(1, 2, 2.2360)]

        [TestCase(2, 2, 2.8284)]

        [TestCase(0, 2, 2.0000)]

        public void CalculateTest(double firstValue, double secondValue, double expected)

        {
            var calculator = new PointRadiusVectorCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
