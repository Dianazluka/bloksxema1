namespace CalcStackDoDies.OneArgument
{
    public class SingradCalc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            var converter = new GradToRadConverter();
            var calculator = new SinCalc();
            return calculator.Calculate(converter.Calculate(first));
        }
    }

}
