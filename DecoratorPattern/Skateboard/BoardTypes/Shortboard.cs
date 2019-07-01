using System;

namespace DecoratorPattern.Skateboard.BoardTypes
{
    public class Shortboard : SkateboardDecorator, ISkateboard
    {
        public Shortboard(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Shortboard Deck, " + this._decoratedSkateboard.GetDescription();
        
        public decimal GetCost() => 10.00m + this._decoratedSkateboard.GetCost();
    }
}