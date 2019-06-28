using System;

namespace StrategyPattern.Duck
{
    public class DisplayAsYellowDuck : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("Displaying a yellow duck");
        }
    }
}