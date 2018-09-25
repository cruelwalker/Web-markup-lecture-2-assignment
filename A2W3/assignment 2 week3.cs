using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            //reading inputs
            Console.Write("Enter First Number:");
            int firstN = int.Parse(Console.ReadLine());

            Console.Write("Enter Second number:");
            int secondN = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            
            // find the hight number

            if (firstN > secondN)
            {
                Console.WriteLine("The highst Number is: " + firstN);
                Console.WriteLine("The Lowest Number is: " + secondN);
                
            }

            else
            {
                Console.WriteLine("The highst Number is: " + secondN);
                Console.WriteLine("The Lowest Number is: " + firstN);

            }


            
            Console.ReadKey();
            Console.WriteLine("****************************************************************************");
            goto start;
             
        }
    }
}
