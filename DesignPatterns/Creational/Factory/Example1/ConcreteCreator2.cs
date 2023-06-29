namespace DesignPatterns.Creational.Factory.Example1
{
    public class ConcreteCreator2 : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProduct2();
        }
    }
}
