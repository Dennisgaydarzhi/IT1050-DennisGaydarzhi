using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = 9;
            int count = 1;

            while (true)
            {
                Console.WriteLine("Enter a number between 1 and 10:");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input < secret)
                {
                    Console.WriteLine("to low");
                    ++count;
                    continue;
                }
                else if (input > secret)
                {
                    Console.WriteLine("to high");
                    ++count;
                    continue;
                }
                else
                {
                    Console.WriteLine("correct");
                    Console.WriteLine($"{count}");
                    
                }
                break;
            }

        }
    }
}
