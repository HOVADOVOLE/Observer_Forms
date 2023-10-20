using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Forms
{
    internal class Device : IObserver
    {
        string name;
        public Device(string name)
        {
            this.name = name;
        }
        public void Update(float temperature, float humidity)
        {
            MessageBox.Show($"Device {name} updated. Temperature: {temperature}°C, Humidity: {humidity}%");
        }
    }
}
