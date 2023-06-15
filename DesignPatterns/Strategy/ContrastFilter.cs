namespace DesignPatterns.Strategy
{
    public class ContrastFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying contrast filter");
        }
    }
}
