﻿using System;

namespace OOPCalculator.OneArgumentCalculator
{
    public class ArctanCalculator: IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates arctangent
        /// </summary>
        /// <param name="firstArgument">Argument</param>
        /// <returns>Resultat</returns>
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}