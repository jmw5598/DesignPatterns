using System;

namespace DecoratorPattern.Skateboard
{
    public class BaseSkateboard : ISkateboard
    {
        public string GetDescription() => "Base Skatboard";
        public decimal GetCost() => 20.00m;
    }
    
}