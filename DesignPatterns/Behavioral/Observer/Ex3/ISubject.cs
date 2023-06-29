namespace DesignPatterns.Behavioral.Observer.Ex3
{
    public interface ISubject
    {
        int State { get; set; }
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
