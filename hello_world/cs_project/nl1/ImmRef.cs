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
    }
}
