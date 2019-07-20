using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class ArcsinCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Нельзя по правилам");
            }
           
            return Math.Asin(firstArgument);
        }

    }
}