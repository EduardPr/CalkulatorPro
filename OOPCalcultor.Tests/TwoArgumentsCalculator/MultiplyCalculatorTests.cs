using NUnit.Framework;
using OOPCalculator;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class MultiplyCalculatorTests

    {
        [Test]
        public void Calculate()
        {
            ITwoArgumentsCalculator calculator = new MultiplyCalculator();
            double result = calculator.Calculate(14, 2);
            Assert.AreEqual(28, result);
        }
    }
}