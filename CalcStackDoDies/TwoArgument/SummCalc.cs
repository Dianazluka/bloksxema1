namespace CalcStackDoDies.TwoArgument
{
    /// <summary>
    /// Function of the calculator, performing addition of real numbers with double precision
    /// </summary>
    public class SummCalc : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method adds the first argument to the second
        /// </summary>
        /// <param name="first">this is first argument</param>
        /// <param name="second">thisis second argument</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}