using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroyApp2
{
    abstract class InstrumentSpec
    {
        private readonly Builder _builder;
        private readonly string _model;
        private readonly Type _type;
        private readonly Wood _backwood;
        private readonly Wood _topwood;

        public InstrumentSpec(Builder builder,string model,Type type,Wood backwood,Wood topwood)
        {
            _builder = builder;
            _model = model;
            _type = type;
            _backwood = backwood;
            _topwood = topwood;
        }

        public Builder GetBuilder() { return _builder; }
        public string GetModel() { return _model; }
        public Type Gettype() { return _type; }
        public Wood GetBackwood() { return _backwood; }
        public Wood GetTopwood() { return _topwood; }

        public virtual bool matches(InstrumentSpec spec)
        {
            if (_builder != spec.GetBuilder())
                return false;
            if ((_model != null) && (!_model.Equals("")) && (!_model.Equals(spec.GetModel())))
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
