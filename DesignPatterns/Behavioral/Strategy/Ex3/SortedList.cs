namespace DesignPatterns.Behavioral.Strategy.Ex3
{
    // Context
    public class SortedList
    {
        private List<string> _list = new();
        private SortStrategy _sortStrategy;

        public SortedList(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string name)
        { 
            _list.Add(name);
        }

        public List<string> Sort()
        {
            _sortStrategy.Sort(_list);

            return _list;
        }
    }
}
