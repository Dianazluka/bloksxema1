namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    ///  Calculator function, finding the sine of an grad angle
    /// </summary>
    public class SingradCalc : OneArgument.IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the sine of the grad angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            var converter = new GradToRadConverter();
            var calculator = new SinCalc();
            return calculator.Calculate(converter.Calculate(first));
        }
    }

}
