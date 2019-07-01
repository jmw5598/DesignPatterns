using System;

namespace DecoratorPattern.Skateboard.Trucks
{
    public class LongboardTrucks : SkateboardDecorator, ISkateboard
    {
        public LongboardTrucks(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Longboard Trucks, " + this._decoratedSkateboard.GetDescription();
        
        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 45.00m;
    }
}