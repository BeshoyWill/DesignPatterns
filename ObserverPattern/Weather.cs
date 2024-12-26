using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ObserverPattern
{
    class Weather
    {
        public double Pressure { get; }
        public double Humidity { get; }
        public double Temperature { get; }

        public Weather (double humd, double pres, double temp)
        {
            Temperature = temp;
            Humidity = humd;
            Pressure = pres;
        }
    }
}
