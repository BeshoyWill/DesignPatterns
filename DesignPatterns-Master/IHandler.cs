using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Master
{
    public interface IHandler
    {
        void AddChain(IHandler handler);
        double? Handle(double[] values, string action);
    }
}
