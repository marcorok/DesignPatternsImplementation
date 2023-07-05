using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    public class ModernChair : IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public void SitOn()
        {
            Console.WriteLine("ModernChair: You are sitting on me!");
        }
    }
}
