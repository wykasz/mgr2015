using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nianio
{
    public class ImmRef
    {
        private Imm value;
        protected int refCount;

        public ImmRef(Imm value)
        {
            this.value = value;
        }

        public Imm getValue()
        {
            return value;
        }

        public void setValue(Imm value)
        {
            this.value = value;
        }

        public String toString()
        {
            return value.toString();
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
