namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the cosine of an grad angle
    /// </summary>
    public class CosgradClas : OneArgument.IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the cosine of the grad angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            var converter = new GradToRadConverter();
            var calculator = new CosCalc();
            return calculator.Calculate(converter.Calculate(first));
        }
    }
}

   