using System;
using System.Collections.Generic;
using System.Linq;
using Builder.Automobiles.Parts;
using Builder.Automobiles.Parts.Addons;
using Builder.Automobiles.Parts.Bodies;
using Builder.Automobiles.Parts.Engines;
using Builder.Automobiles.Parts.Frames;
using Builder.Automobiles.Parts.Wheels;

namespace Builder.Automobiles
{
    public class Automobile
    {
        public AutomobileFrame Frame { get; set; }
        public AutomobileBody Body { get; set; }
        public AutomobileEngine Engine { get; set; }
        public AutomobileWheels Wheels { get; set; }
        public IList<AutomobilePart> Addons { get; set; }

        public override string ToString()
        {
            var addons = this.Addons
                .Select(e => e.Description)
                .Aggregate((a, b) => a + ", " + b);

            return "FRAME: \t\t" + this.Frame.Description + "\n" +
                "BODY: \t\t" + this.Body.Description + "\n" +
                "ENGINE: \t" + this.Engine.Description + "\n" +
                "WHEELS: \t" + this.Wheels.Description + "\n" +
                "ADDONS: \t" + addons;
        }
    }
}