using System;
using AbstractFactoryPattern.Automobiles.Parts;

namespace AbstractFactoryPattern.Automobiles.Parts.Bodies
{
    public abstract class AutomobileBody : AutomobilePart
    {
        public AutomobileBody(string description) : base(description) {}
    }
}