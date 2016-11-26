using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._6_229g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the first array: ");
            int m = int.Parse(Console.ReadLine());
            int countera = 0;
            int suma = 0;
            double averagea = 0;
            int[] a = new int[m];
            for (int i = 0; i < a.Length; i++)
            {
                 Console.WriteLine("a[" + i + "]= ");
                 a[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 5 == 0)
                {
                    countera = countera + 1;
                    suma = suma + a[i];
                    averagea = (double)suma / countera;
                }
            }
            Console.WriteLine("Average of the elements that are divisible by 5: {0:f2}", averagea);
            Console.WriteLine("-------------------------------------------------------|");
            Console.WriteLine("Enter the length of the second array: ");
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            int counterb = 0;
            int sumb = 0;
            double averageb = 0;
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("b[" + i + "]= ");
                b[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 5 == 0)
                {
                    counterb = counterb + 1;
                    sumb = sumb + b[i];
                    averageb = (double)sumb / counterb;
                }
            }
            Console.WriteLine("Average of the elements that are divisible by 5: {0:f2}", averageb);
            Console.WriteLine("-------------------------------------------------------|");
            Console.WriteLine("Enter the length of the third array: ");
            int k = int.Parse(Console.ReadLine());
            int[] c = new int[k];
            int counterc = 0;
            int sumc = 0;
            double averagec = 0;
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("c[" + i + "]= ");
                c[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < c.Length; i++)
            {
                if (b[i] % 5 == 0)
                {
                    counterc = counterc + 1;
                    sumc = sumc + c[i];
                    averagec = (double)sumc / counterc;
                }
            }
            Console.WriteLine("Average of the elements that are divisible by 5: {0:f2}", averagec);
            if (averagea < averageb && averagea < averagec)
            {
                Console.WriteLine("The minimal average is: "+ averagea);
            }
            if (averageb < averagea && averageb < averagec)
            {
                Console.WriteLine("The minimal average is: " + averageb);
            }
            if (averagec < averagea && averagec < averageb)
            {
                Console.WriteLine("The minimal average is: " + averagec);
            }



        }
    }
}
