using System;

namespace StrategyPattern.Duck
{
    public class DisplayAsYellowDuck : IDisplayBehavior
    {
        public void display()
        {
            Console.WriteLine("Displaying a yellow duck");
        }
    }
}