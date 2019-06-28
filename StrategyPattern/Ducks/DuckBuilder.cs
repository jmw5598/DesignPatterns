using System;

namespace StrategyPattern.Duck
{
    public class DuckBuilder
    {
        private IDisplayBehavior _displayBehavior;
        private IQuackBehavior _quackBehavior;
        private IFlyBehavior _flyBehavior;

        public DuckBuilder WithDisplayBehavior(IDisplayBehavior displayBehavior)
        {
            this._displayBehavior = displayBehavior;
            return this;
        }

        public DuckBuilder WithQuackBehavior(IQuackBehavior quackBehavior)
        {
            this._quackBehavior = quackBehavior;
            return this;
        }

        public DuckBuilder WithFlyBehavior(IFlyBehavior flyBehavior)
        {
            this._flyBehavior = flyBehavior;
            return this;
        }

        public Duck Build()
        {
            return new Duck(
                this._displayBehavior, 
                this._quackBehavior, 
                this._flyBehavior);
        }

    }
    
}