using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature;
            Console.WriteLine("Please enter a temperature");
            temperature = int.Parse(Console.ReadLine());

            if (temperature < 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if (temperature < 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (temperature < 30)
            {
                Console.WriteLine("Moose");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (temperature < 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temperature < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temperature < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temperature < 90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("Bug");
            }
        }
    }
}
