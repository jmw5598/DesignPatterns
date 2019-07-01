using System;
using AbstractFactoryPattern.Automobiles.Parts;

namespace AbstractFactoryPattern.Automobiles.Parts.Engines
{
    public abstract class AutomobileEngine : AutomobilePart
    {
        public AutomobileEngine(string description) : base(description) {}
    }
}