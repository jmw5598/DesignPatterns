using System;
using Builder.Automobiles;
using Builder.Automobiles.Parts;
using Builder.Automobiles.Parts.Addons;
using Builder.Automobiles.Parts.Bodies;
using Builder.Automobiles.Parts.Engines;
using Builder.Automobiles.Parts.Frames;
using Builder.Automobiles.Parts.Wheels;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobile = new AutomobileBuilder()
                .WithFrame(new TruckFrame())
                .WithBody(new TruckBody())
                .WithEngine(new V6Engine())
                .WithWheels(new PremiumWheels())
                .WithAddon(new Sunroof())
                .WithAddon(new CDPlayer())
                .WithAddon(new Bluetooth())
                .Build();
            
            Console.WriteLine(automobile.ToString());
        }
    }
}
