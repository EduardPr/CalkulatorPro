using System;

namespace OOPCalculator
{
    public class OneArgumentsFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Sin":
                    return new SinusCalculator();
                case "Cos":
                    return new CosinusCalculator();
                case "Tan":
                    return new TanCalculator();
                case "Arcsin":
                    return new ArcsinCalculator();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}