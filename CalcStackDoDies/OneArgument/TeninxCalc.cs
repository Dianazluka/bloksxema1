using System;

namespace CalcStackDoDies.OneArgument
{
    public class TeninxCalc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }
    }
}
