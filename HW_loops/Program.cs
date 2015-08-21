using System;

namespace HW_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество клиентов (N):");

            int N = int.Parse(Console.ReadLine());
            int fact=1;
           
            do
            {
                 if (N == 1) break;
                 fact = fact * N;
                 N--;
            }
            while (N >= 1);
            Console.WriteLine("Количество возможных вариантов доставки товара - {0}",fact);
        }
    }
}
