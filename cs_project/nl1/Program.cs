using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nianio
{
    class Program
    {
        static void Main(string[] args)
        {
            Imm[] args_arr = new Imm[args.Length+1];
            args_arr[0] = new ImmString("pn");
            for (int i = 0; i < args.Length; ++i)
                args_arr[i+1] = new ImmString(args[i]);
            ImmArray args_imm = new ImmArray(args_arr);
            //test_NL.test2();
            //test_dzialka_NL.main();
            //Console.WriteLine("ok");
            compiler_NL.NL_compile(args_imm);
            //Console.Read();
        }
    }
}
