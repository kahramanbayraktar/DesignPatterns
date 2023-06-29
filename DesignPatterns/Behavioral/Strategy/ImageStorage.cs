namespace DesignPatterns.Behavioral.Strategy
{
    // Strategy Pattern is related to OCP (Open/Closed principle).
    // It's a behavioral type of pattern.
    // It is similar to State Pattern.
    // The difference is that, in State Pattern abstract classes are used.
    // Interface vs abstract class: when all methods come as a package, use abstract class.
    // Otherwise use interface to spread methods into different interfaces.
    public class ImageStorage
    {
        //private readonly ICompressor _compressor;
        //private readonly IFilter _filter;

        //public ImageStorage(ICompressor compressor, IFilter filter)
        //{
        //    _compressor = compressor;
        //    _filter = filter;
        //}

        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}
