namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Function that finds a quotient of a unit by a given number
    /// </summary>
    public class OnedivxCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// A method that calculates the quotient of a unit by a given number
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return 1/first;
        }
    }
}
