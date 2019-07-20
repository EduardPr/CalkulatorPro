using System;

namespace OOPCalculator.OneArgumentCalculator
{
    /// <summary>
    /// Factory for one argument functions
    /// </summary>
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
                case "Ln":
                    return new LnCalculator();
                case "Log2":
                    return new Log2Calculator();
                case "Log10":
                    return new Log10Calculator();
                case "Pow":
                    return new XPowTwoCalculator();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}