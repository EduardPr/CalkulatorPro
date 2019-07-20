using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class Log2Calculator: IOneArgumentCalculator
    {
      
    public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("Нельзя по правилам");
            }
            return Math.Log(firstArgument,2);
        }
    }
}