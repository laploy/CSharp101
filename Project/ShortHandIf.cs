using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c = 0;

            if(a > b)
            {
                c = 1;
            }
            else
            {
                c = 2;
            }

            // ------ shorthand if
            c = a > b ? 1 : 2;
        }
    }
}
