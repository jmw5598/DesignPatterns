using System;

namespace AbstractFactoryPattern.Automobiles.Parts
{
    public abstract class AutomobilePart
    {
        public AutomobilePart(string description)
        {
            this.Description = description;
        }

        public string Description { get; }
    }
}