using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class PointDegreeCalculatorTests

    {
        [TestCase(1, 2, 1.1071)]

        [TestCase(2, 2, 0.7853)]

        [TestCase(3, 2, 0.5880)]

        public void CalculateTest(double firstValue, double secondValue, double expected)

        {
            var calculator = new PointDegreeCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
