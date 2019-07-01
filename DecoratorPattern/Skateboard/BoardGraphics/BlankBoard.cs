using System;

namespace DecoratorPattern.Skateboard.BoardGraphics
{
    public class BlankBoard : SkateboardDecorator, ISkateboard
    {
        public BlankBoard(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Blank Graphic, " + this._decoratedSkateboard.GetDescription();

        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 2;
    }
}