namespace DesignPatterns.Creational.Factory.Example1
{
    public class ConcreteProduct1 : IProduct
    {
        public override void SomeOperation()
        {
            Console.WriteLine("Some operation from Concrete Product 1");
        }
    }
}
