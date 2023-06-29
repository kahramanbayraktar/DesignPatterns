namespace DesignPatterns.Behavioral.Strategy
{
    public class ContrastFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying contrast filter");
        }
    }
}
