using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;

            Console.WriteLine("Enter first integer");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second interger");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine($"Sum is {sum}");

            int x = 1;
            int y = 2;
            int z = 3;
            int solution;

            solution = (x + y) * (z + 10);
            Console.WriteLine($"Solution is {solution}");

            Console.WriteLine("Hello \tWorld!");
            Console.WriteLine("Hello \nWorld");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("hello\\world");
        }
    }
}
