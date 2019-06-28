using System;

namespace StrategyPattern.Duck
{
    public class DisplayAsRubberDuck : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("Displaying a rubber duck");
        }
    }
}