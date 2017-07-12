namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the arc sine of an grad angle
    /// </summary>
    public class ArcsingradCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the arc sine of the grad angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            var converter = new RadToGradConverter();
            var calculator = new ArcsinCalc();
            return converter.Calculate(calculator.Calculate(first));
        }
    }
}
