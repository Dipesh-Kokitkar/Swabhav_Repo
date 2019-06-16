using System;
using System.Collections.Generic;
using System.Linq;
using InventroyApp2;
using System.Text;

namespace InventoryApp3
{
    class InstrumentSpec
    {
        private Dictionary<string, object> _properties;

        public InstrumentSpec(Dictionary<string, object> dictionary)
        {
            if (dictionary == null)
                _properties = new Dictionary<string, object>();
            else
            {
                _properties = new Dictionary<string, object>(dictionary);
            }
        }

        public object GetProperty(string propertyname)
        {
            object value = "";
            _properties.TryGetValue(propertyname, out value);
            return value;
        }

        public Dictionary<string, object> Properties
        {
            get { return _properties; }
        }

        public bool Matches(InstrumentSpec spec)
        {
            foreach (KeyValuePair<string, object> property in spec.Properties)
            {

                if (!property.Value.Equals(this.GetProperty(property.Key)))
                    return false;
            }
            return true;
        }
    }
}

