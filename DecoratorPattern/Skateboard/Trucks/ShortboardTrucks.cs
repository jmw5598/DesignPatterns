using System;

namespace DecoratorPattern.Skateboard.Trucks
{
    public class ShortboardTrucks : SkateboardDecorator, ISkateboard
    {
        public ShortboardTrucks(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Shortboard Trucks, " + this._decoratedSkateboard.GetDescription();
        
        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 45.00m;
    }
}