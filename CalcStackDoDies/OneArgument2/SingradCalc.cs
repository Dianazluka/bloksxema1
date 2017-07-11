namespace CalcStackDoDies.OneArgument2
{
    public class SingradCalc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            var converter = new GradToRadConverter();
            var calculator = new SingradCalc();
            return calculator.Calculate(converter.Calculate(first));
        }
    }

}
