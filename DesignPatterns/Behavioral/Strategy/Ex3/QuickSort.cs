namespace DesignPatterns.Behavioral.Strategy.Ex3
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
        }
    }
}
