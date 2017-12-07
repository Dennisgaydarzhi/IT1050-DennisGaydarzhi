using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09_4
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringList();
        }
        static void QueryStringList()
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

            var TSpaces = from i in T
                          where i.EndsWith("ber")
                          select i;

            foreach (string i in TSpaces)
            {
                Console.WriteLine(i);
                count++;
            }

            Console.WriteLine("Count:" + count);
            Console.WriteLine("Capacity:" + T.Capacity);

        }


    }
}
