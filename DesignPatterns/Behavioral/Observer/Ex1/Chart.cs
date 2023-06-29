namespace DesignPatterns.Behavioral.Observer.Example1
{
    public class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart got updated.");
        }
    }
}
