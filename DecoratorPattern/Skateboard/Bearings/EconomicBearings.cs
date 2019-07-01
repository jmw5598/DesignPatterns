using System;

namespace DecoratorPattern.Skateboard.Bearings
{
    public class EconomicBearings : SkateboardDecorator, ISkateboard
    {
        public EconomicBearings(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Economic Bearings, " + this._decoratedSkateboard.GetDescription();

        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 5;
    }
}