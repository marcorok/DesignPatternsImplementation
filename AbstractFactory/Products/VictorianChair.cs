using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    public class VictorianChair : IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public void SitOn()
        {
            Console.WriteLine("Victorian Chair: You are sitting on me!");
        }
    }
}
