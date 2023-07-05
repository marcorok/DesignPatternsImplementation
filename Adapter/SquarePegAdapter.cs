using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SquarePegAdapter : RoundPeg
    {
        private readonly SquarePeg Peg;
        
        public SquarePegAdapter(SquarePeg peg) : base (0) => Peg = peg;

        public new int GetRadius()
        {
            return (int)(Peg.GetWidth() * Math.Sqrt(2) / 2) ;
        }
    }
}
