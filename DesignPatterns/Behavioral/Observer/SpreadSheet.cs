namespace DesignPatterns.Behavioral.Observer
{
    public class SpreadSheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("SpreashSheet got modified.");
        }
    }
}
