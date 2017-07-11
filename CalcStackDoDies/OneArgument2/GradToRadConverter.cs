using System;

namespace CalcStackDoDies.OneArgument2
{
    public class GradToRadConverter : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return first * Math.PI / 180;
        }
    }
}