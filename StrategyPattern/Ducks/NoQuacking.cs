using System;

namespace StrategyPattern.Duck
{
    public class NoQuacking : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Sorry, I don't know how to quack!");
        }
    }
}