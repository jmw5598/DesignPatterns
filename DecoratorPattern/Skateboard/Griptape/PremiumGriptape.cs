using System;

namespace DecoratorPattern.Skateboard.Griptape
{
    public class PremiumGriptape : SkateboardDecorator, ISkateboard
    {
        public PremiumGriptape(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Premium Griptape, " + this._decoratedSkateboard.GetDescription();
        
        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 7.00m;
    }
}