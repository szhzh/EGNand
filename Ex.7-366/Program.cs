using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7_366
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter EGN(1): ");
            string egn1 = Console.ReadLine();
            Console.WriteLine("Enter EGN(2): ");
            string egn2 = Console.ReadLine();
            int year1 = int.Parse(egn1.Substring(0, 2));
            int year2 = int.Parse(egn2.Substring(0, 2));
            if (year1 > year2)
            {
                Console.WriteLine("The person with the first EGN is younger.");
            }
            if (year1 < year2)
            {
                Console.WriteLine("The person with the second EGN is younger.");
            }
            if (year1 == year2)
            {
                int month1 = int.Parse(egn1.Substring(2, 2));
                int month2 = int.Parse(egn2.Substring(2, 2));
                if (month1 > month2)
                {
                    Console.WriteLine("The person with the first EGN is younger.");
                }
                if (month1 < month2)
                {
                    Console.WriteLine("The person with the second EGN is younger.");
                }
                if (month1 == month2)
                {
                    int day1 = int.Parse(egn1.Substring(4, 2));
                    int day2 = int.Parse(egn2.Substring(4, 2));
                    if (day1 > day2)
                    {
                        Console.WriteLine("The person with the first EGN is younger.");
                    }
                    if (day1 < day2)
                    {
                        Console.WriteLine("The person with the second EGN is younger.");
                    }
                    if (day1 == day2)
                    {
                        Console.WriteLine("The two persons are with the same age");
                    }
                }
            }              
        }
    }
}
