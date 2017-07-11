using System;

namespace CalcStackDoDies
{
    public class SinCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }

}