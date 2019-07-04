using System;
using System.Threading;
using ObserverPattern.Generic;
using ObserverPattern.Hydroponics;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new HydroponicDataSubject();
            var webClient = new WebClient().Subscribe(subject);
            var mobileClient = new MobileClient().Subscribe(subject);

            subject.Next(new HydroponicData{
                Temperature = 10,
                Humidity = 12
            });

            Console.WriteLine("New reading 5 seconds... \n");
            Console.WriteLine("WebClient Unsubscribed... \n");

            webClient.Unsubscribe();
            Thread.Sleep(5000);

            subject.Next(new HydroponicData{
                Temperature = 15,
                Humidity = 13
            });
        }
    }
}
