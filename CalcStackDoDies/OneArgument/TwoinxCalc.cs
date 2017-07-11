using System;

namespace CalcStackDoDies.OneArgument
{
    public class TwoinxCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(2, first);
        }
    }
}
