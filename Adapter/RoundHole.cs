using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class RoundHole
    {
        private readonly int Radius;
        public RoundHole(int radius) {
            Radius = radius;    
        }

        public int GetRadius() { 
            return Radius;
        }

        public bool Fits(RoundPeg peg) {
            return Radius >= peg.GetRadius();
        }
    }
}
