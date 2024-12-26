using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Master
{
    public class SubtractionHandler : BaseHandler
    {
        public override double? Handle(double[] values, string action)
        {
            if (action.ToLower() == "minus")
            {
                var result = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    result -= values[i];
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
