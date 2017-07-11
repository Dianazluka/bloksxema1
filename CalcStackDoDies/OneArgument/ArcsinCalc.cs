using System;

namespace CalcStackDoDies.OneArgument
{
    public class ArcsinCalc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }

}
 