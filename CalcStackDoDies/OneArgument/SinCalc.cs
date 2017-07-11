using System;

namespace CalcStackDoDies.OneArgument
{
    public class SinCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }

}