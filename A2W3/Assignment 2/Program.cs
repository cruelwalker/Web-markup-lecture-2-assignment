using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
          //input
            Console.Write("Enter a number (1..4): ");
            string input = Console.ReadLine();
            int numb = int.Parse(input);
            //definning the output using switch.command
            switch (numb)
            {
                case 1:
                    Console.WriteLine("clubs");
                    break;
                case 2:
                    Console.WriteLine("diamonds");
                    break;
                case 3:
                    Console.WriteLine("hearts");
                    break;
                case 4:
                    Console.WriteLine("spades");
                    break;
                default:
                    Console.WriteLine("Incorrect Answer");
                    break;
            }

            Console.ReadKey();

        }
    }
}
