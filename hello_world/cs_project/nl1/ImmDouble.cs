using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nianio
{
    public class ImmDouble : Imm
    {
        protected Object value;
        protected int refCount;

        public ImmDouble(double number) {
            value = number;
	    }
	
	    public Object getValue() {
		    return (double)value;
	    }

        public double getDoubleValue()
        {
            return (double)value;
        }

        public Imm clone()
        {
            return new ImmDouble((double)value);
        }
	
	    public String toString() {
		    return getValue().ToString();
	    }

    }
}
