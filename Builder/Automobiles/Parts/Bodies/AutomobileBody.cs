using System;
using Builder.Automobiles.Parts;

namespace Builder.Automobiles.Parts.Bodies
{
    public abstract class AutomobileBody : AutomobilePart
    {
        public AutomobileBody(string description) : base(description) {}
    }
}