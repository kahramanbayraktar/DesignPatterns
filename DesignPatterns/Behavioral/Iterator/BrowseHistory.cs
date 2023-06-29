namespace DesignPatterns.Behavioral.Iterator
{
    public class BrowseHistory
    {
        private readonly List<string> _urls = new();
        public List<string> Urls => _urls;

        public void Push(string url)
        {
            _urls.Add(url);
        }

        public void Pop()
        {
            _urls.RemoveAt(_urls.Count - 1);
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator
        {
            private readonly BrowseHistory _history;
            private int _index;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }

            public string Current()
            {
                return _history.Urls[_index];
            }

            public bool HasNext()
            {
                return _index < _history.Urls.Count;
            }

            public string Next()
            {
                return _history.Urls[_index++];
            }
        }
    }
}
