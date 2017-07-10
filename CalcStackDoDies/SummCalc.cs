using System;

namespace CalcStackDoDies
{
    public class SummCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}