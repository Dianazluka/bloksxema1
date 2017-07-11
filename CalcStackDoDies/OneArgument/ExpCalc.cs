using System;

namespace CalcStackDoDies
{
    public class ExpCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
