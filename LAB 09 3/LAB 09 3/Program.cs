using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09_3
{
    class Program
    {

        static void Main(string[] args)
        {
            int count = 0;
            List<string> T = new List<string>();

            T.Capacity = 6;
            T.Add("January");
            T.Add("Febuary");
            T.Add("March");
            T.Add("April");
            T.Add("May");
            T.Add("June");
            T.Add("july");
            T.Add("August");
            T.Add("Spetember");
            T.Add("October");
            T.Add("November");
            T.Add("December");

            foreach (string i in T)
            {
                Console.WriteLine(i);
                count++;
            }
            Console.WriteLine("Count:" + count);
            Console.WriteLine("Capacity:" + T.Capacity);
        } 
    }
}
