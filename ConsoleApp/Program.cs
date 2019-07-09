using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string coach_number = "";

            do
            {
                Console.WriteLine("Please, enter 8 number:");
                coach_number = Console.ReadLine();
                Console.Clear();
            } while (!FreightCoach.IsDigit(coach_number));
            Console.WriteLine("Freight coach number {0}", coach_number);


            if(FreightCoach.IsFreightCoach(coach_number, out int true_number))
            {
                Console.WriteLine("Number of freight coach is correctly!");
            }
            else
            {
                Console.WriteLine("Number of freight coach is wrong!");
                Console.WriteLine("Last number is {0}", true_number);
            }

            Console.ReadKey();
        }
    }
}
