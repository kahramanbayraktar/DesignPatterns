namespace DesignPatterns.Behavioral.Strategy.Ex1
{
    public class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using JPEG");
        }
    }
}
