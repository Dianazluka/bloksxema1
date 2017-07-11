using System;

namespace CalcStackDoDies.OneArgument2
{
    public class ArcsingradCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            var converter = new GradToRadConverter();
            var calculator = new ArcsinCalc();
            return calculator.Calculate(converter.Calculate(first));
        }
    }
}
