using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedlimit
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedlimit = 35;
            int speed = 42;

            if (speed > speedlimit)
            {
                Console.WriteLine("SLOW DOWN");
            }
        }
    }
}
