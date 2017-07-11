using System;

namespace CalcStackDoDies.OneArgument2
{
    public class ArctanCalc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
