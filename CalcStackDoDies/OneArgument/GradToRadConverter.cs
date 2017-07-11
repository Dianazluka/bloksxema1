using System;

namespace CalcStackDoDies.OneArgument
{
    public class GradToRadConverter : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return first * Math.PI / 180;
        }
    }
}