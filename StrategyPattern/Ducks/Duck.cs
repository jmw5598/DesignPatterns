using System;

namespace StrategyPattern.Duck
{
    public class Duck
    {
        private readonly IDisplayBehavior _displayBehavior;
        private readonly IQuackBehavior _quackBehavior;
        private readonly IFlyBehavior _flyBehavior;

        public Duck(
            IDisplayBehavior displayBehavior, 
            IQuackBehavior quackBehavior, 
            IFlyBehavior flyBehavior)
        {
            this._displayBehavior = displayBehavior;
            this._quackBehavior = quackBehavior;
            this._flyBehavior = flyBehavior;
        }

        public void display()
        {
            this._displayBehavior.display();
        }

        public void quack()
        {
            this._quackBehavior.quack();
        }

        public void fly() 
        {
            this._flyBehavior.fly();
        }
    }
}