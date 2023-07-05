using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public interface IHandler
    {
        public IHandler SetNext(IHandler handler);

        public object Handle(object request);
    }
}
