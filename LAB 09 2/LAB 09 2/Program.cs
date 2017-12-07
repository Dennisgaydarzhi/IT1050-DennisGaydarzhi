using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09_2
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();
        }
          
        static void QueryStringArray()
        {
            var fruits = new[] { "apple", "mango", "orange", "apricot", "cherry", "grape", "blueberry" };

            var Uppercase = from fruit in fruits
                               where fruit.StartsWith("a")

                               select fruit.ToUpper();

            foreach(var fruit in Uppercase)
            {
                Console.WriteLine(fruit);
            }



        }
    }
}
