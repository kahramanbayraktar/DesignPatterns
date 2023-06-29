namespace DesignPatterns.Behavioral.Strategy.Ex2
{
    public class StrategyAdd : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
