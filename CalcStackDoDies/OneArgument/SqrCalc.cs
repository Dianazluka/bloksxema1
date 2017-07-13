namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Function of the calculator, finding the square of a given number
    /// </summary>
    public class SqrCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that calculates the square of a given number
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return first * first;
        }
    }

}
