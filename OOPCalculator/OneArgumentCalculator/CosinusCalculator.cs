using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class CosinusCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }

    }
}