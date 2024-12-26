using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Master
{
    public class AdditionHandler : BaseHandler
    {
        public override double? Handle(double[] values, string action)
        {
            if (action.Equals("add", StringComparison.CurrentCultureIgnoreCase))
            {
                double result = 0.0;
                foreach (var value in values)
                {
                    result += value;
                }
                return result;
            }
            else
            {
                return _nextInLine?.Handle(values, action);
            }
        }
    }
}
