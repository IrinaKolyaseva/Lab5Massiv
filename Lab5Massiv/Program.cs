using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double[] numb = new double[7];
                double SA=0;
                for (int i = 0; i < numb.Length; i++)
                {
                    Console.Write($"Введите элемент массива {i+1}: ");
                    numb[i]=double.Parse(Console.ReadLine());
                    SA+=numb[i]/7;
                }
                Console.WriteLine(SA);
            }
            Console.ReadKey();
        }
     
    }
}
