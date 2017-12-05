using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = new[] { "apple", "mango", "orange", "apricot", "cherry", "grape", "blueberry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

    }
}
