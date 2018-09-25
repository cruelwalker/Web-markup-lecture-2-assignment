using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.Write("Enter the first number: ");
            int numb1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numb2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numb3 = int.Parse(Console.ReadLine());

            if (numb2 > numb3 && numb1 > numb3)
               

               {
                Console.WriteLine("The third number is the smallest of the three");

            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three");

            }
            Console.ReadKey();
            Console.WriteLine("-------------------------------------------------------------------");
            goto start;
            
        }
    }
}
