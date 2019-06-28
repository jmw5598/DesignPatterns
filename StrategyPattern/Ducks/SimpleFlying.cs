using System;

namespace StrategyPattern.Duck
{
    public class SimpleFlying : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I simply just fly...");
        }
    }
}