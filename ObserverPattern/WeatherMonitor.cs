using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ObserverPattern
{
    sealed class WeatherMonitor : IObserver<Weather>
    {
        private IDisposable _cancellation;
        private readonly string _name;

        public void Subscribe(WeatherSupplier provider)
        {
            _cancellation = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _cancellation.Dispose();
        }

        public WeatherMonitor(string name)
        {
            _name = name;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            WriteLine("Error has occured");
        }

        public void OnNext(Weather value)
        {
            WriteLine(_name);
            if (_name.Contains("T"))
            {
                string op = $"| Temperature : {value.Temperature} Celisus |";
                Write(op);
            }
            if (_name.Contains("P"))
            {
                string op = $"| Pressure : {value.Pressure} atm|";
                Write(op);
            }
            if (_name.Contains("H"))
            {
                string op = $"| Humidity : {value.Humidity * 100} % |";
                Write(op);
            }
            if (!(_name.Contains("T") || _name.Contains("P") || _name.Contains("H")))
            {
                OnError(new Exception());
            }
            WriteLine();
        }
    }
}
