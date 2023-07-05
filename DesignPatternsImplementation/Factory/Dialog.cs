using FactoryMethod.Products;

namespace FactoryMethod.Factory
{
    /*
     * Abstract Factory
     */
    public abstract class Dialog
    {
        public void Render()
        {
            IButton okButton = CreateButton();
            okButton.Render();
        }

        public abstract IButton CreateButton();
    }
}