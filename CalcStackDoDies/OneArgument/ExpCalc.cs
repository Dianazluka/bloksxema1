using System;

namespace CalcStackDoDies.OneArgument
{
    public class ExpCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
