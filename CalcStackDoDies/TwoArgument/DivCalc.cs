namespace CalcStackDoDies.TwoArgument
{
    /// <summary>
    /// Function of the calculator, performing division of real numbers with double precision
    /// </summary>
    public class DivCalc : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method divides the first argument by the second
        /// </summary>
        /// <param name="first">this is first argument</param> 
        /// <param name="second">thisis second argument</param> 
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first / second;
        }
    }
}