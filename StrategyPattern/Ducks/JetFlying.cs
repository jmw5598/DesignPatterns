using System;

namespace StrategyPattern.Duck
{
    public class JetFlying : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying at jet speed...");
        }
    }
}