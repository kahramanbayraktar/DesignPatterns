namespace DesignPatterns.Behavioral.Observer.Example1
{
    public class SpreadSheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("SpreashSheet got modified.");
        }
    }
}
