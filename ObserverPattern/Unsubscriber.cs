using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Unsubscriber<TWeather> : IDisposable
    {
        private readonly List<IObservable<TWeather>> _observers;
        private readonly IObservable<TWeather> _observer;
        private List<IObserver<Weather>> observers;
        private IObserver<Weather> observer;

        public Unsubscriber(List<IObserver<Weather>> observers, IObserver<Weather> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        internal Unsubscriber(List<IObservable<TWeather>> observers, IObservable<TWeather> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
