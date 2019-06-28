using System;

namespace StrategyPattern.Duck
{
    public class SimpleQuacking : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack Quack!");
        }
    }
}