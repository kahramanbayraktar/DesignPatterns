namespace DesignPatterns.Creational.Factory.Example1
{
    public class ConcreteCreator1 : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProduct1();
        }
    }
}
