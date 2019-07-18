using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OOPCalculator
{
    public class MinCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < secondArgument) return firstArgument;
            else return secondArgument;

        }

    }
}