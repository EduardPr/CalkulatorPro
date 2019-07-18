using System;

namespace OOPCalculator
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}