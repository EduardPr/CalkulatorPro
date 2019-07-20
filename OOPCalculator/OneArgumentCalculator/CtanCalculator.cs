using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class CtanCalculator:IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates cotangent
        /// </summary>
        /// <param name="firstArgument">Argument</param>
        /// <returns>Resultat</returns>
        public double Calculate(double firstArgument)
        {
            return 1/Math.Tan(firstArgument);
        }
    }
}