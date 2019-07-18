using System;

namespace OOPCalculator.TwoArgumentsCalculator
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Add":
                    return new AdditionCalculator();
                case "Subtraction":
                    return new SubtractionCalculator();
                case "Multiplication":
                    return  new MultiplyCalculator();
                case "Division":
                    return new DivisionCalculator();
                case "Min":
                    return new MinCalculator();
                case "Max":
                    return new MaxCalculator();
                case "Arith":
                    return new ArithmeticMeanCalculator();
                case "Geom":
                    return new GeometricMeanCalculator();
                case "Remainder":
                    return new RemainderDivisionCalculator();
                case "XPowY":
                    return new XPowYCalculator();
                case "XPow1DivisionY":
                    return new XPow1DivisionYCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}