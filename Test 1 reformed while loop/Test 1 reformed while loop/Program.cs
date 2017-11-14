using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1_reformed_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int i = 10;
            while (i < n)
            {
                Console.Write("*");
                i++;
            }
            // the do while loop has one * while the while loop does not
        }

    }
}
