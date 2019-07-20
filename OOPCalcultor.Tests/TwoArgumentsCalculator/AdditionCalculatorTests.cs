using NUnit.Framework;
using OOPCalculator;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void Calculate()
        {
            ITwoArgumentsCalculator calculator = new AdditionCalculator();
            double result = calculator.Calculate(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}