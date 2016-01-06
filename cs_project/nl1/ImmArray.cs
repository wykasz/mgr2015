using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nianio
{
    class ImmArray : Imm
    {
        protected List<Imm> value;
        protected int refCount;

        public ImmArray(Imm[] array)
        {
            value = new List<Imm>(array); 
        }

        public ImmArray(List<Imm> list)
        {
            value = list;
        }

        public new Object getValue()
        {
            return value;
        }

        public new List<Imm> getArrayValue()
        {
            return value;
        }

        public int getCount()
        {
            return value.Count;
        }

        public Imm clone()
        {
            return new ImmArray(value.ToArray());
        }

        public String toString() {
		StringBuilder sb = new StringBuilder();
        foreach (Imm imm in getArrayValue())
        {
			sb.Append(imm.toString()).Append(",");
		}
		return sb.ToString();
	}

    }
}
