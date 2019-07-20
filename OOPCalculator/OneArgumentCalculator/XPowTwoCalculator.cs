using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class XPowTwoCalculator: IOneArgumentCalculator
    {
        /// <summary>
        /// Squaring a number
        /// </summary>
        /// <param name="firstArgument">Base</param>
        /// <returns>Resultat</returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}