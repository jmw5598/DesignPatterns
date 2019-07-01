using System;

namespace DecoratorPattern.Skateboard.Griptape
{
    public class StandardGriptape : SkateboardDecorator, ISkateboard
    {
        public StandardGriptape(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Standard Griptape, " + this._decoratedSkateboard.GetDescription();
        
        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 3.00m;
    }
}