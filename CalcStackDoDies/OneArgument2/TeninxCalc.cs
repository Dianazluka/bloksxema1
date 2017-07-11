using System;

namespace CalcStackDoDies.OneArgument2
{
    public class TeninxCalc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(10,first);
        }
    }
}
