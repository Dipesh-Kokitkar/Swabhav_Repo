using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroyApp2
{
    class GuitarSpec:InstrumentSpec
    {
        private int _numstring;
       
        public GuitarSpec(Builder builder, string model, Type type,
            int numstring, Wood backwood, Wood topwood):base(builder,model,type,backwood,topwood)
        {
            
            _numstring = numstring;
           
        }
      
        public int Getnumstring() { return _numstring; }
       
        public override bool matches(InstrumentSpec spec)
        {

            if (!base.matches(spec))
                return false;
            GuitarSpec spec2 =(GuitarSpec) spec;
            if (_numstring != spec2.Getnumstring())
                return false;
            return true;
        }
    }

}

