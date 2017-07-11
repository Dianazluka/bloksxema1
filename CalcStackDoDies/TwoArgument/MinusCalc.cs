namespace CalcStackDoDies
{
    public class MinusCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}