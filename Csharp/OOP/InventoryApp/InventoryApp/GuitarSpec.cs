using System;

namespace InventoryApp
{
    class GuitarSpec
    {
        private Builder _builder;
        private string _model;
        private Type _type;
        private int _numstring;
        private Wood _backwood;
        private Wood _topwood;

        public GuitarSpec(Builder builder, string model, Type type, int numstring, Wood backwood, Wood topwood)
        {
            _builder = builder;
            _model = model;
            _type = type;
            _numstring = numstring;
            _backwood = backwood;
            _topwood = topwood;
        }
        public Builder GetBuilder() { return _builder; }
        public string GetModel() { return _model; }
        public Type Gettype() { return _type; }
        public int Getnumstring() { return _numstring; }
        public Wood GetBackwood() { return _backwood; }
        public Wood GetTopwood() { return _topwood; }
        public bool matches(GuitarSpec spec)
        {
            if (_builder != spec.GetBuilder())
                return false;
            if ((_model != null) && (!_model.Equals("")) && (!_model.Equals(spec.GetModel())))
                return false;
            if (_numstring != spec.Getnumstring())
                return false;
            if (_type != spec.Gettype())
                return false;
            if (_backwood != spec.GetBackwood())
                return false;
            if (_topwood != spec.GetTopwood())
                return false;
            return true;
        }
    }
}
