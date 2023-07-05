namespace FactoryMethod.Products
{
    internal class HTMLButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("I'm rendering a HTML Button");
        }
    }
}