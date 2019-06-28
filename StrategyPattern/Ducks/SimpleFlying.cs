using System;

namespace StrategyPattern.Duck
{
    public class SimpleFlying : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I simply just fly...");
        }
    }
}