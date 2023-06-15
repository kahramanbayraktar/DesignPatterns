namespace DesignPatterns.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        string Current();
        string Next();
    }
}
