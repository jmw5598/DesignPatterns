using System;

namespace DecoratorPattern.Skateboard.Wheels
{
    public class ShortboardWheels : SkateboardDecorator, ISkateboard
    {
        public ShortboardWheels(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Shortboard Wheels, " + this._decoratedSkateboard.GetDescription();
        
        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 25.00m;
    }
}