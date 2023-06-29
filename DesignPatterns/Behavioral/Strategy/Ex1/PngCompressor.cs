namespace DesignPatterns.Behavioral.Strategy.Ex1
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
