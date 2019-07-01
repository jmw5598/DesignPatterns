using System;

namespace DecoratorPattern.Skateboard.BoardGraphics
{
    public class GraphicBoard : SkateboardDecorator, ISkateboard
    {
        public GraphicBoard(ISkateboard decoratedSkateboard) : base(decoratedSkateboard) {}

        public string GetDescription() => "Graphic Board, " + this._decoratedSkateboard.GetDescription();

        public decimal GetCost() => this._decoratedSkateboard.GetCost() + 10m; 
    }
}