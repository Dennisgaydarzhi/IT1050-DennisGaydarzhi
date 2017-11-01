using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<101; i++)
            {
                if ((i % 2) == 0)
                    Console.WriteLine($"{i} its even");

                else if ((i % 2) != 0)
                    Console.WriteLine($" {i} its odd");
            }
        }
    }
}
