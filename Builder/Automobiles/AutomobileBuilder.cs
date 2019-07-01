using System;
using System.Collections.Generic;
using Builder.Automobiles.Parts;
using Builder.Automobiles.Parts.Addons;
using Builder.Automobiles.Parts.Bodies;
using Builder.Automobiles.Parts.Engines;
using Builder.Automobiles.Parts.Frames;
using Builder.Automobiles.Parts.Wheels;

namespace Builder.Automobiles
{
    public class AutomobileBuilder
    {
        private AutomobileBody _body;
        private AutomobileEngine _engine;
        private AutomobileFrame _frame;
        private AutomobileWheels _wheels;
        private IList<AutomobilePart> _addons;

        public AutomobileBuilder()
        {
            this._addons = new List<AutomobilePart>();
        }

        public AutomobileBuilder WithBody(AutomobileBody body)
        {
            this._body = body;
            return this;
        }

        public AutomobileBuilder WithEngine(AutomobileEngine engine)
        {
            this._engine = engine;
            return this;
        }

        public AutomobileBuilder WithFrame(AutomobileFrame frame)
        {
            this._frame = frame;
            return this;
        }

        public AutomobileBuilder WithWheels(AutomobileWheels wheels)
        {
            this._wheels = wheels;
            return this;
        }

        public AutomobileBuilder WithAddon(AutomobilePart part)
        {
            this._addons.Add(part);
            return this;
        }

        public Automobile Build()
        {
            return new Automobile()
            {
                Body = this._body,
                Engine = this._engine,
                Frame = this._frame,
                Wheels = this._wheels,
                Addons = this._addons
            };
        }
    }    
}