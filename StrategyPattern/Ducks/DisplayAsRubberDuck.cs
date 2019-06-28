using System;

namespace StrategyPattern.Duck
{
    public class DisplayAsRubberDuck : IDisplayBehavior
    {
        public void display()
        {
            Console.WriteLine("Displaying a rubber duck");
        }
    }
}