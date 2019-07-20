using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class ArcsinCalculator: IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates arcsine
        /// </summary>
        /// <param name="firstArgument">Argument</param>
        /// <returns>Resultat</returns>
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