using System;
using Builder.Automobiles.Parts;

namespace Builder.Automobiles.Parts.Engines
{
    public abstract class AutomobileEngine : AutomobilePart
    {
        public AutomobileEngine(string description) : base(description) {}
    }
}