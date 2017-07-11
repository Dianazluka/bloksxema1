namespace CalcStackDoDies.TwoArgument
{
    public class MulCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}