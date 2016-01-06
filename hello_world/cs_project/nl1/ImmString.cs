using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nianio
{
    public class ImmString : Imm
    {
        protected Object value;
        protected int refCount;

        public ImmString(String _value) {
            value = _value;
	    }
	
	    public Object getValue() {
		    return (String)value;
	    }

        public String getStringValue()
        {
            return (String)value;
        }

        public Imm clone()
        {
            return new ImmString((String)value);
        }
	
	    public String toString() {
		    return (String)value;
	    }


        public static bool operator ==(ImmString c1, ImmString c2) 
        {
            return c1.getValue().Equals(c2.getValue());
        }
        
        public static bool operator !=(ImmString c1, ImmString c2)
        {
            return !c1.getValue().Equals(c2.getValue());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            return this == (ImmString)obj;
        }
    }
}
