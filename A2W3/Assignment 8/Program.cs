using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            //input
            Console.Write("Enter number of working hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());

            Console.Write("Enter number of failures: ");
            int failures = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            //staements 
            if (hours >10000 || years>=7 || failures > 25)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced.");
            }
            Console.ReadKey();
            Console.WriteLine("");
            goto start;
        }
    }
}
