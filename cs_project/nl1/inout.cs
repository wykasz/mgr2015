using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nianio
{
    public class inout_NL
    {
        public static Imm print(Imm arg)
        {
            Console.Write(arg.toString());
            return null;
        }

        public static Imm print_endl()
        {
            Console.WriteLine("");
            return null;
        }

        public static Imm read_number()
        {
            string s = "";
            char c = (char)Console.Read();
            while (!is_digit(c))
            {
                c = (char)Console.Read();
            }

            while (is_digit(c))
            {
                s = s + c;
                c = (char)Console.Read();
            }
            return new ImmDouble(double.Parse(s));
        }

        private static bool is_digit(char c)
        {
            if (c == '-') return true;
            if (c == '.') return true;
            if (c >= '0' && c <= '9') return true;
            return false;
        }
    }
}
