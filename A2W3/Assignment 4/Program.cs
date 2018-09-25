using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //collecting inputs
            Console.Write("Enter the first number: ");
            int numb1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numb2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int numb3 = int.Parse(Console.ReadLine());
            //calculations
            int sum = numb1 + numb2 + numb2;
            int average = sum / 3;
            int product = numb1 * numb2 * numb3;
            //display
            Console.WriteLine("sum = "+sum);
            Console.WriteLine("average = "+ average);
            Console.WriteLine("product = " + product);
            //finding the highest number
            if (numb1>numb2 && numb1 > numb3)
            {
                Console.WriteLine("The highst number is: " + numb1);

            }
            else if (numb2 > numb3 && numb2 >numb3)
            {
                Console.WriteLine("The highst number is: " + numb2);
            }
            else 
            {
                Console.WriteLine("The highst number is: " + numb3);
            }


            if (numb1 < numb2 && numb1 < numb3)
            {
                Console.WriteLine("The lowest number is: " + numb1);

            }
            else if (numb2 < numb3 && numb2 < numb3)
            {
                Console.WriteLine("The lowest number is: " + numb2);
            }
            else
            {
                Console.WriteLine("The lowest number is: " + numb3);
            }

            Console.ReadKey();


        }
    }
}
