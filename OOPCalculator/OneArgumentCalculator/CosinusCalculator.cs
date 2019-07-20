using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class CosinusCalculator:IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates cosine
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>Resultat</returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }

    }
}