using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nianio
{
    public class ImmHash : Imm
    {
        protected Object value;
        private String name;
        protected int refCount;

        public ImmHash(Dictionary<String, Imm> _value) {
            value = _value;
	    }
	
	    public Dictionary<String, Imm> getHashValue() {
		    return (Dictionary<String, Imm>)value;
	    }

        public Object getValue()
        {
            return value;
        }
	
	    public Imm clone() {
		    return new ImmHash(new Dictionary<String,Imm>(getHashValue()));
	    }
	
	    public Imm get(String key) {
            return getHashValue()[key];
	    }

        public void set(String key, Imm value)
        {
            getHashValue()[key] = value;
        }
	
	    public String toString() {
		    StringBuilder sb = new StringBuilder();
		    foreach (KeyValuePair<String, Imm> entry in getHashValue()) {
			    sb.Append(entry.Key).Append(":");
			    sb.Append(entry.Value.toString()).Append(",\n");
		    }
		    return sb.ToString();
	    }

        public void incRef()
        {
            ++refCount;
        }

        public void decRef()
        {
            --refCount;
        }
    }
}
