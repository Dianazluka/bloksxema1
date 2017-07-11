using System;

namespace CalcStackDoDies
{
    public class CosCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }

}
 