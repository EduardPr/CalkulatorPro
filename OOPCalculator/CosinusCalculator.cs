using System;

namespace OOPCalculator
{
    public class CosinusCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }

    }
}