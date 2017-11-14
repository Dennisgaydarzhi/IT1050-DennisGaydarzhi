using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1_2_128_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            while (x <= 128)
            {
                Console.WriteLine("{" + x + "]");
                x * 2;

            }
        }
    }
}
