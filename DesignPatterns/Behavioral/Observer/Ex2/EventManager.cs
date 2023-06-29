namespace DesignPatterns.Behavioral.Observer.Ex2
{
    public class EventManager
    {
        private List<IEventListener> _listeners;

        public void Subscribe(IEventListener listener)
        {
            _listeners.Add(listener);
        }

        public void Unsubscribe(IEventListener listener)
        {
            _listeners.Remove(listener);
        }

        public void Notify(Type eventType, string message)
        {
            foreach (var listener in from listener in _listeners
                                     where listener is eventType
                                     select listener)
            {
                listener.Update(message);
            }
        }
    }
}
