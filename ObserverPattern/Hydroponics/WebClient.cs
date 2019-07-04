using ObserverPattern.Generic;

namespace ObserverPattern.Hydroponics
{
    public class WebClient : Observer<HydroponicData>
    {
        public override void OnNext(HydroponicData data)
        {
            System.Console.WriteLine("WebClient\n-------------------");
            System.Console.WriteLine("TEMP: \t" + data.Temperature);
            System.Console.WriteLine("HUM: \t" + data.Humidity + "\n");
        }
    }
}