using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Forms
{
    internal class WeatherStation
    {
        float temperature, humidity;
        static List<IObserver> observers = new List<IObserver>();

        void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity);
            }
        }
        public void SetMeasurements(float temperature, float humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Notify();
        }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(int id)
        {
            observers.RemoveAt(id);
        }

    }
}

