namespace DesignPatterns.Behavioral.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        string Current();
        string Next();
    }
}
