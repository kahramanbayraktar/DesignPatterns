namespace DesignPatterns.Behavioral.Strategy.Ex2
{
    public class StrategyMultiply : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
