namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the number opposite to the specified
    /// </summary>
    public class MinusxCalc : OneArgument.IOneArgumentsCalculator
    {
        /// <summary>
        /// A method that calculates a number opposite to a given
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return -first;
        }
    }
}