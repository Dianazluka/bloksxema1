using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Function calculator, raising the number e to a given degree
    /// </summary>
    public class ExpCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method for raising to the power
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
