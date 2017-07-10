using System;

namespace CalcStackDoDies
{
    public class MulCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}