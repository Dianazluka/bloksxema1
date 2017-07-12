namespace CalcStackDoDies.OneArgument
{
    public class ArcsingradCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            var converter = new RadToGradConverter();
            var calculator = new ArcsinCalc();
            return converter.Calculate(calculator.Calculate(first));
        }
    }
}
