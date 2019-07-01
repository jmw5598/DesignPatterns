using System;
using AbstractFactoryPattern.Automobiles.Parts;

namespace AbstractFactoryPattern.Automobiles.Parts.Wheels
{
    public abstract class AutomobileWheels : AutomobilePart
    {
        public AutomobileWheels(string description) : base(description) {}
    }
}