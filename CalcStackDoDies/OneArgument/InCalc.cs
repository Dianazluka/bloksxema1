using System;

namespace CalcStackDoDies
{
    public class InCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first, Math.E);
        }
    }

}
 