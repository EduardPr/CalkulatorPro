using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class ArctanCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
          
            return Math.Atan(firstArgument);
        }
    }
}