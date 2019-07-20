using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class EPowerX: IOneArgumentCalculator
    {
        /// <summary>
        /// Exponential exponentiation
        /// </summary>
        /// <param name="firstArgument">Power</param>
        /// <returns>Resultat</returns>
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}
