using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    class Program:MyMath
    {
        static void Main(string[] args)
        {
            
            double x = 10;
            double y = 10;

            Multiply(x, y);
            GetResult();

            Divide(x, y);
            GetResult();

            Subtract(x, y);
            GetResult();

            Add(x, y);
            GetResult();
        
        }

        
    }
}
