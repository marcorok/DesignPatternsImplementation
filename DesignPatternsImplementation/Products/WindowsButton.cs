using FactoryMethod.Products;

namespace FactoryMethod
{
    internal class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("I'm rendering a Windows Button");
        }
    }
}