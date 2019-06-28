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

        public void Display()
        {
            this._displayBehavior.Display();
        }

        public void Quack()
        {
            this._quackBehavior.Quack();
        }

        public void Fly() 
        {
            this._flyBehavior.Fly();
        }
    }
}