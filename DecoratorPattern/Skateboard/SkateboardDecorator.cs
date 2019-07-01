using System;

namespace DecoratorPattern.Skateboard
{
    public abstract class SkateboardDecorator
    {
        protected readonly ISkateboard _decoratedSkateboard;

        public SkateboardDecorator(ISkateboard decoratedSkateboard)
        {
            this._decoratedSkateboard = decoratedSkateboard;
        }
    }
}