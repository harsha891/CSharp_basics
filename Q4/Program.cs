using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sales bar chart
            int[] storeSales = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter today’s sales for store " + (i+1) + ": ");
                storeSales[i] = int.Parse(Console.ReadLine()); // Enter non negative sales
                while(storeSales[i] < 0)
                {
                    Console.Write("Sales value cannot be negative, RE Enter today’s sales for store " + (i + 1) + ": ");
                    storeSales[i] = int.Parse(Console.ReadLine()); // Enter non negative sales
                }
            }
            Console.WriteLine();

            Console.WriteLine("SALES BAR CHART");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Store " + (i+1) + ": ");
                for(int j = 0; j < storeSales[i]/100; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
