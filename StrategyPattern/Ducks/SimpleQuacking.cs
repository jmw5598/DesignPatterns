using System;

namespace StrategyPattern.Duck
{
    public class SimpleQuacking : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack!");
        }
    }
}