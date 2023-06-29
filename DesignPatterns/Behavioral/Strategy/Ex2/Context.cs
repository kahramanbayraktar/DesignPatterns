namespace DesignPatterns.Behavioral.Strategy.Ex2
{
    public class Context
    {
        public IStrategy Strategy { get; set; }

        public Context(IStrategy strategy)
        {
            this.Strategy = strategy;   
        }

        public int ExecuteStrategy(int a, int b)
        {
            return Strategy.Execute(a, b);
        }
    }
}
