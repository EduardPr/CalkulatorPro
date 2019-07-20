using System;
using NUnit.Framework;
using OOPCalculator.TwoArgumentsCalculator;

namespace OOPCalcultor.Tests.TwoArgumentsCalculator
{
    public class TwoArgumentsFactoryTests
    {
        [TestCase("Add", typeof(AdditionCalculator))]
        [TestCase("Arith", typeof(ArithmeticMeanCalculator))]
        [TestCase("Division", typeof(DivisionCalculator))]
        [TestCase("Geom", typeof(GeometricMeanCalculator))]
        [TestCase("LogX", typeof(LogX))]
        [TestCase("Max", typeof(MaxCalculator))]
        [TestCase("Min", typeof(MinCalculator))]
        [TestCase("Multiplication", typeof(MultiplyCalculator))]
        [TestCase("PointDegree", typeof(PointDegreeCalculator))]
        [TestCase("RadiusVector", typeof(PointRadiusVectorCalculator))]
        [TestCase("Remainder", typeof(RemainderDivisionCalculator))]
        [TestCase("Subtraction", typeof(SubtractionCalculator))]
        [TestCase("XPow1DivisionY", typeof(XPow1DivisionYCalculator))]
        [TestCase("XPowY", typeof(XPowYCalculator))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}