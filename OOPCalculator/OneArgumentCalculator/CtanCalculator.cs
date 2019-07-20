using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class CtanCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
           
            return 1/Math.Tan(firstArgument);
        }
    }
}