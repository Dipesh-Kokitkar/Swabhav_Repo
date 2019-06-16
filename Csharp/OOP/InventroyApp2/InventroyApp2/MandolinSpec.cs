using System;

namespace InventroyApp2
{
    class MandolinSpec:InstrumentSpec
    {
        private readonly Style _style;

        public MandolinSpec(Builder builder, string model, Type type,Style style,
              Wood backwood, Wood topwood):base(builder,model,type,backwood,topwood)
        {
            _style = style;
        }

        public Style GetStyle
        {
            get { return _style; }

        }

        public override bool matches(InstrumentSpec spec)
        {

            if (!base.matches(spec))
                return false;
            MandolinSpec spec2 = (MandolinSpec)spec;
            if (_style != spec2.GetStyle)
                return false;
            return true;
        }
    }
}
