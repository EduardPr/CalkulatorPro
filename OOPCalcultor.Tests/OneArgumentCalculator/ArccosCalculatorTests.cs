using System;
using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class ArccosCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(-1, 3.1415)]
        [TestCase(0, 1.5707)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArccosCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }

        [Test]
        public void DivisionByZeroTest()
        {
            IOneArgumentCalculator calculator = new ArccosCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(14));
        }
    }
}