using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1_6_boolean_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            bool icyRain = false;
            bool tornadoWarning = false;
           if ( icyRain || tornadoWarning == false)
            {
                Console.WriteLine("Lets go outside!");
            }
        }
    }
}
