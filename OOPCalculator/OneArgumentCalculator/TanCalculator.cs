using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class TanCalculator:IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates tangent
        /// </summary>
        /// <param name="firstArgument">Argument</param>
        /// <returns>Resultat</returns>
        public double Calculate(double firstArgument)
        {
            
            return Math.Tan(firstArgument);
        }

    }
}