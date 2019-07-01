using System;

namespace DecoratorPattern.Skateboard.Bearings
{
    public class StandardBearings : SkateboardDecorator, ISkateboard
    {
        public StandardBearings(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Standard Bearings, " + this._decoratedSkateboard.GetDescription();

        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 10;
    }
}