using System;

namespace CalcStackDoDies
{
    public class DivCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first / second;
        }
    }
}