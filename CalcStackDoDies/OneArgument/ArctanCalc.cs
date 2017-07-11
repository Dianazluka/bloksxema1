using System;

namespace CalcStackDoDies.OneArgument
{
    public class ArctanCalc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
