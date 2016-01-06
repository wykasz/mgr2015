using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nianio
{
    public interface Imm
    {
        Object getValue();

        Imm clone();

        String toString();
    }
}
