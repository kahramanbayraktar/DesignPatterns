namespace DesignPatterns.Behavioral.Observer.Ex3
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject.State > 0)
            { 
                // The value is greater than 0, so do sth.
            }
        }
    }
}
