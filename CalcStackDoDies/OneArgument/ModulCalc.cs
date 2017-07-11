using System;

namespace CalcStackDoDies
{
    public class ModulCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
