using System;
using StrategyPattern.Duck;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var fastQuietRubberDuck = new DuckBuilder()
                .WithDisplayBehavior(new DisplayAsRubberDuck())
                .WithQuackBehavior(new NoQuacking())
                .WithFlyBehavior(new JetFlying())
                .Build();

            fastQuietRubberDuck.display();
            fastQuietRubberDuck.quack();
            fastQuietRubberDuck.fly();
        }
    }
}
