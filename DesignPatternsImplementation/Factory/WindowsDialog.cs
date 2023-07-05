using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
