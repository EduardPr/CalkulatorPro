using NUnit.Framework;
using OOPCalculator;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class DivisionCalculatorTests

    {
        [Test]
        public void Calculate()
        {
            ITwoArgumentsCalculator calculator = new DivisionCalculator();
            double result = calculator.Calculate(14, 2);
            Assert.AreEqual(7, result);
        }
    }
}