using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Master
{
    public abstract class BaseHandler : IHandler
    {
        public void AddChain(IHandler handler)
        {
            _nextInLine = handler;
        }

        public abstract double? Handle(double[] values, string action);

        protected IHandler _nextInLine;
    }
}
