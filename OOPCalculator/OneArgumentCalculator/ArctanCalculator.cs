using System;

namespace OOPCalculator
{
    public class ArctanCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}