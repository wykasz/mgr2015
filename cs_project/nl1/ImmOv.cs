using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nianio
{
    public class ImmOv : Imm
    {
        protected Object value;
	    private String name;
        protected int refCount;
	
	    public ImmOv(String label){
		    name = label;
	    }
	
	    public ImmOv (String label, Object _value){
            value = _value;
		    name = label;
	    }
	
	    public Imm clone() {
            return new ImmOv(getName(), cloneOvValue());
	    }

        private Object cloneOvValue()
        {
            if (value == null) return null;
            return getOvValue().clone();
        }

	    public String getName() {
		    return name;
	    }
	
	    public Object getValue() {
		    return value;
	    }

        public Imm getOvValue()
        {
            return (Imm)value;
        }
	
	    public String toString() {
		    return getName() + " : " + getValue().ToString();
	    }

    }
}
