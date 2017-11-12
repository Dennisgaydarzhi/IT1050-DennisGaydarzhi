using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1_infinite_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keeplooping = true;

            do
            {
                Console.WriteLine("true");

            } while (keeplooping == true);
               
        }
    }
}
