using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class SinusCalculatorTests

    {
        [Test]
        public void Calculate()
        {
            IOneArgumentCalculator calculator = new SinusCalculator();
            double result = calculator.Calculate(14);
            Assert.AreEqual(0.9906, result,0.0001);
        }
    }
}