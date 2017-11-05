using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06_grocery_store
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputItem;
            Decimal inputCost;
            Decimal TotalCost = 0;
            string inputContinue = "";
            string allItems = "";

            while ( inputContinue != "e" && inputContinue != "E")
            {
                Console.Write("Please enter the next item:");
                inputItem = Console.ReadLine();

                Console.Write("Enter the item cost:");
                inputCost = Convert.ToDecimal(Console.ReadLine());

                    if(inputItem.Trim() !="")
                    {
                    allItems += inputItem + "\n";
                    TotalCost += inputCost;
                    }
                Console.WriteLine("Press <enter> to continue, E to end");
                inputContinue = Console.ReadLine();
            }
            Console.WriteLine("Grocery Items:");
            Console.WriteLine(allItems);

            Console.WriteLine("total Cost:" + TotalCost);
        }
    }
}
