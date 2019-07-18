using System;
using NUnit.Framework;
using OOPCalculator.OneArgumentCalculator;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.OneArgumentCalculator
{
    public class OneArgumentsFactoryTests
    {
        //IsInstanceOf:

        [TestCase("Arccos", typeof(ArccosCalculator))]
        [TestCase("Arcsin", typeof(ArcsinCalculator))]
        [TestCase("Arctan", typeof(ArctanCalculator))]
        [TestCase("Cos", typeof(CosinusCalculator))]
        [TestCase("Ctan", typeof(CtanCalculator))]
        [TestCase("Expow", typeof(EPowerX))]
        [TestCase("Ln", typeof(LnCalculator))]
        [TestCase("Log10", typeof(Log10Calculator))]
        [TestCase("Log2", typeof(Log2Calculator))]
        [TestCase("Sin", typeof(SinusCalculator))]
        [TestCase("Tan", typeof(TanCalculator))]
        [TestCase("Pow", typeof(XPowTwoCalculator))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}