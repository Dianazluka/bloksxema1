namespace CalcStackDoDies.TwoArgument
{
    /// <summary>
    ///  Function of the calculator, performing multiple of real numbers with double precision
    /// </summary>
    public class MulCalc : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method multiplies the first argument by the second
        /// </summary>
        /// <param name="first">this is first argument</param>
        /// <param name="second">this is second argument</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}