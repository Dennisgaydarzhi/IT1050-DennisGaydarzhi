using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_to_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Double celsius;
            Double fahrenheit = Convert.ToDouble(Console.ReadLine());

            if(fahrenheit < 40)
            {
                Console.WriteLine("It is cold");
            }
            else
                Console.WriteLine("It is hot");

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"celsius {celsius}");
        }
    }
}
