using System;

namespace DecoratorPattern.Skateboard.Bearings
{
    public class PremiumBearings : SkateboardDecorator, ISkateboard
    {
        public PremiumBearings(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Premium Bearings, " + this._decoratedSkateboard.GetDescription();

        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 20;
    }
}