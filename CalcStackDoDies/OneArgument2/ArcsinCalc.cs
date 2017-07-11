using System;

namespace CalcStackDoDies.OneArgument2
{
    public class ArcsinCalc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }

}
 