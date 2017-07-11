using System;

namespace CalcStackDoDies.OneArgument
{
    public class ModulCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
