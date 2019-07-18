﻿using System;

namespace OOPCalculator
{
    public class Log2Calculator: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument,2);
        }
    }
}