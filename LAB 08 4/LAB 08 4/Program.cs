using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_08_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomnumber = new int[1000];
            Random random = new Random();
            for (int i = 0; i < randomnumber.Length; i++)
            {
                randomnumber[i] = random.Next(0, 100);
            }
            foreach (int i in randomnumber)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}

