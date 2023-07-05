using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SquarePeg
    {
        private readonly int Width;
        public SquarePeg(int width) {
            Width = width;
        }

        public int GetWidth() { 
            return Width;
        }
    }
}
