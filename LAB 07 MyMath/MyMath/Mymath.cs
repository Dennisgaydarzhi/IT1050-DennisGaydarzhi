using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class MyMath
    {
        public double operand1;
        public double operand2;
        public static double Result = 0;
        static public void Multiply(double operand1, double operand2)
        {
            Result = operand1 * operand2;
            Console.WriteLine(operand1+ "*"+operand2+"=");
        }
        static public void Divide(double operand1, double operand2)
        {
            Result = operand1 / operand2;
            Console.WriteLine(operand1 + "/" + operand2 + "=");
        }
        static public void Subtract(double operand1, double operand2)
        {
            Result = operand1 - operand2;
            Console.WriteLine(operand1 + "-" + operand2 + "=");
        }
        static public void Add(double operand1, double operand2)
        {
            Result = operand1 + operand2;
            Console.WriteLine(operand1 + "+" + operand2+"=");
        }
        static public void GetResult()
        {
            Console.WriteLine(Result);
        }
    }
}
