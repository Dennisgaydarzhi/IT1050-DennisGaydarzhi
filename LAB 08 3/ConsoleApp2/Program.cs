using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seasons = new string[4];

            seasons[0] = "Winter";
            seasons[1] = "Spring";
            seasons[2] = "Summer";
            seasons[3] = "Fall";

            foreach (string season in seasons)
            {
                Console.Write(season + ","); 

            }

        }
    }
}
