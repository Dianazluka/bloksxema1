using System;

namespace CalcStackDoDies.OneArgument2
{
    public class ArccosCalc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }

}
