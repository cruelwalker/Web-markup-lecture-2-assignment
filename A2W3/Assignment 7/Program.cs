using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            //input
            Console.Write("Enter weight (kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your hight (cm): ");
            double hight = double.Parse(Console.ReadLine());

            Console.Write("Enter your gender (male/female): ");
            string input = Console.ReadLine();

            double bmi = (weight*10000) / (hight*hight);

            /* male 
             * bmi = weight / hight*hight
             * weight = (hight*hight) *bmi
             */
            double maleH = (hight * hight) * bmi;

            if (input == "female")
            {
                double femaleH1 = ((hight * hight) * 19)/10000;
                double femaleH2 = ((hight * hight) * 24)/10000;
                Console.WriteLine("bmi-value: " + bmi.ToString("0.0"));
                Console.WriteLine("normal bmi-value (min...max): 19..24 ");
                Console.WriteLine("Healthy weight range: "+femaleH1.ToString("0.0")+".."
                                                            +femaleH2.ToString("0.0"));
            }

            else if (input == "male")
            {
                double maleH1 = ((hight * hight) * 20)/10000;
                double maleH2 = ((hight * hight) * 25)/10000;

                Console.WriteLine("bmi-value: " + bmi.ToString("0.0"));
                Console.WriteLine("normal bmi-value (min...max): 20..25");
                Console.WriteLine("Healthy weight range: "+maleH1.ToString("0.0")+".."
                                                           +maleH2.ToString("0.0"));

            }
            else
            {
                Console.WriteLine("Incorrect Gender Input");
            }

            Console.ReadKey();
            Console.WriteLine("--------------------------------------------------------------------");
            goto start;

        }
    }
}
