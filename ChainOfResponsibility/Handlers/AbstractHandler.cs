using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
    }
}
