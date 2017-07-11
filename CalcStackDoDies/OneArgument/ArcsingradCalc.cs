namespace CalcStackDoDies.OneArgument
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
