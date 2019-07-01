using System;

namespace DecoratorPattern.Skateboard
{
    public interface ISkateboard
    {
        string GetDescription();
        decimal GetCost();
    }
}