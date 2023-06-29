namespace DesignPatterns.Behavioral.Strategy.Ex1
{
    public class ContrastFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying contrast filter");
        }
    }
}
