using System;
using Builder.Automobiles.Parts;

namespace Builder.Automobiles.Parts.Wheels
{
    public abstract class AutomobileWheels : AutomobilePart
    {
        public AutomobileWheels(string description) : base(description) {}
    }
}