using System;

namespace CalcStackDoDies.OneArgument
{
    public class log10Calc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first, 10);
        }
    }
}
