using System;

namespace CalcStackDoDies
{
    public class SqrCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return first * first;
        }
    }

}
