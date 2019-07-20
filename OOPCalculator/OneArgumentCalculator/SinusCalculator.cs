using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class SinusCalculator: IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates sinus
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>Resultat</returns>
        public double Calculate(double firstArgument)
        {
          
            return Math.Sin(firstArgument);
        }
    }
}