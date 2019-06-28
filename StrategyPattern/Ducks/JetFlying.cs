using System;

namespace StrategyPattern.Duck
{
    public class JetFlying : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Flying at jet speed...");
        }
    }
}