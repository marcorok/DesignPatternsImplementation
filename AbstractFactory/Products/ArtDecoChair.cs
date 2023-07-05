using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    internal class ArtDecoChair : IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public void SitOn()
        {
            Console.WriteLine("ArtDecoChair: You are sitting on me!");
        }
    }
}
