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
                case "Arccos":
                    return new ArccosCalculator();
                case "Ctan":
                    return new CtanCalculator();
                case "Arctan":
                    return new ArctanCalculator();
                case "Expow":
                    return new EPowerX();
                case "Log10":
                    return new LnCalculator();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}