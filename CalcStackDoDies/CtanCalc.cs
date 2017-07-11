using System;

namespace CalcStackDoDies
{
    public class CtanCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return 1 / Math.Tan(first);
        }
    }

}
