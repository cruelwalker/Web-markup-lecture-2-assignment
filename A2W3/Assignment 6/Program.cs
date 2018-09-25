using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            //input
            Console.Write("Enter code: ");
            int input = int.Parse(Console.ReadLine());
            //definning input range with grades
            if (input >= 90 && input <= 100)
            {
                Console.WriteLine("Grade = A");
                Console.WriteLine("Course passed");
            }
            else if (input <= 89 && input >= 80)
            {
                Console.WriteLine("Grade = B");
                Console.WriteLine("Course passed");
            }
            else if (input <= 79 && input >= 70)
            {
                Console.WriteLine("Grade = C");
                Console.WriteLine("Course passed");
            }
            else if (input <= 69 && input >= 60)
            {
                Console.WriteLine("Grade = D");
                Console.WriteLine("Course not passed");
            }
            else
            {
                Console.WriteLine("Grade = F");
                Console.WriteLine("Course not passed");
            }
            Console.ReadKey();
            goto start;
        }
    }
}
