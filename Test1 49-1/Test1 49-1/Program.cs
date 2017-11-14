using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_49_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (x = 49; x > 0;)
            {
                Console.Write("{0},", x);
                x--;
            }
            Console.ReadLine();
            
        }
    }
}
