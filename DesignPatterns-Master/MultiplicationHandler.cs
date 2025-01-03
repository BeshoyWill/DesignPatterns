﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Master
{
    public class MultiplicationHandler : BaseHandler
    {
        public override double? Handle(double[] values, string action)
        {
            if (action.ToLower() == "multiply")
            {
                var result = 1.0;
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
