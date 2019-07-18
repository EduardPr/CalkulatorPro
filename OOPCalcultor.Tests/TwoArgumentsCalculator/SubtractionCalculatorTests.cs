using NUnit.Framework;
using OOPCalculator;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class SubtractionCalculatorTests

    {
        [Test]
        public void Calculate()
        {
            ITwoArgumentsCalculator calculator = new SubtractionCalculator();
            double result = calculator.Calculate(14, 2);
            Assert.AreEqual(12, result);
        }
    }
}