using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HTMLButton();
        }
    }
}
