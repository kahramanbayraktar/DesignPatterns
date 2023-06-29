namespace DesignPatterns.Behavioral.Observer.Ex3
{
    public class ConcreteSubject : ISubject
    {
        // This is just an example of the class state. It can be anything to inform the subscribers about.
        public int State { get; set; } = 0;
        
        private List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // TODO: Shouldn't be called from outside the class, I think.
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        { 
            // Do sth important

            // Then notify all subscribers
            Notify();
        }
    }
}
