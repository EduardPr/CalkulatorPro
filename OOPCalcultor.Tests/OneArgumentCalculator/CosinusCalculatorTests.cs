using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    [TestFixture]
    public class CosinusCalculatorTests

    {
        [Test]
        public void Calculate()
        {
            IOneArgumentCalculator calculator = new CosinusCalculator();
            double result = calculator.Calculate(14);
            Assert.AreEqual(0.1367, result, 0.0001);
        }
    }
}