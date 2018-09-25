using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            //Read numbers
            Console.Write("Enter the first number: ");
            int numb1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numb2 = int.Parse(Console.ReadLine());

            //calculations
            int div = numb2 / numb1;
            int multi = numb1 * div;
            int div2 = numb1 / numb2;
            int multi2 = numb2 * div2;

            //statements finding the multibles
            if (multi != numb2 && multi2 != numb1)
            {
                Console.WriteLine("Numbers are not multibles");
            }
 
            else  if (multi == numb2)
            {
                Console.WriteLine("Number 2 is multible to number 1");
            }
            else
            {
                Console.WriteLine("Number 1 is multible to number 2");
            }
            Console.WriteLine("____________________________________________________________________");

            Console.ReadKey();
            goto start;
        }
    }
}
