using System;

namespace DecoratorPattern.Skateboard.BoardTypes
{
    public class Longboard : SkateboardDecorator, ISkateboard
    {
        public Longboard(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Longboard Deck, " + this._decoratedSkateboard.GetDescription();
        
        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 15.00m;
    }
}