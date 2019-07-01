using System;

namespace DecoratorPattern.Skateboard.Wheels
{
    public class LongboardWheels : SkateboardDecorator, ISkateboard
    {
        public LongboardWheels(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Longboard Wheels, " + this._decoratedSkateboard.GetDescription();
        
        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 35.00m;
    }
}