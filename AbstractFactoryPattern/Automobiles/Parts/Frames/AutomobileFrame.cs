using System;
using AbstractFactoryPattern.Automobiles.Parts;

namespace AbstractFactoryPattern.Automobiles.Parts.Frames
{
    public abstract class AutomobileFrame : AutomobilePart
    {
        public AutomobileFrame(string description) : base(description) {}
    }
}