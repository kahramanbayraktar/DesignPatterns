namespace DesignPatterns.Behavioral.Observer.Ex3
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject.State == 0)
            { 
                // The value is 0, so do sth.
            }
        }
    }
}
