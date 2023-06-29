namespace DesignPatterns.Behavioral.Strategy.Ex1
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying B&W filter");
        }
    }
}
