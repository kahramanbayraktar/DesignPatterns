namespace DesignPatterns.Behavioral.Observer.Example1
{
    public class DataSource : Subject
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;

                NotifyObservers();
            }
        }
    }
}
