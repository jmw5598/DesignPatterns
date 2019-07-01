using System;
using Builder.Automobiles.Parts;

namespace Builder.Automobiles.Parts.Frames
{
    public abstract class AutomobileFrame : AutomobilePart
    {
        public AutomobileFrame(string description) : base(description) {}
    }
}