using System;

namespace CalcStackDoDies.OneArgument
{
    public class ArccosCalc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }

}
