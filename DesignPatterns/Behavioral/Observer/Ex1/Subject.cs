namespace DesignPatterns.Behavioral.Observer.Example1
{
    // aka Observable
    public class Subject
    {
        private List<IObserver> _observers = new();

        // Attach()
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        // Detach()
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // Notify()
        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
