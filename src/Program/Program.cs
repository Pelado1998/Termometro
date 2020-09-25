using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IObservable<TemperatureSensor> monitor = new IObservable<TemperatureSensor>();
            TemperatureReporter reporter = new TemperatureReporter();
            reporter.StartReporting(monitor);
            monitor.GetTemperature();
        }
    }
}