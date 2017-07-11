using System;

namespace CalcStackDoDies.OneArgument
{
    public class CosCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }

}
 