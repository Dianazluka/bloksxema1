using System;

namespace CalcStackDoDies.OneArgument2
{
    public class log10Calc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first, 10);
        }
    }
}
