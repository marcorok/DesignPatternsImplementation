using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Adapter
{
    public class RoundPeg
    {
        private readonly int Radius;
        public RoundPeg(int radius)
        {
            Radius = radius;
        }

        public int GetRadius()
        {
            return Radius;
        }
    }
}
