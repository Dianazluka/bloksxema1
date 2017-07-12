namespace CalcStackDoDies.TwoArgument
{
    /// <summary>
    /// Function of the calculator, performing subtraction of real numbers with double precision
    /// </summary>
    public class MinusCalc : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method subtracts the second argument from the first
        /// </summary>
        /// <param name="first">this is first argument</param>
        /// <param name="second">thisis second argument</param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}