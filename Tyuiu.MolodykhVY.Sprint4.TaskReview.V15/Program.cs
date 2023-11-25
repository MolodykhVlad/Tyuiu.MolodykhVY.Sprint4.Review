using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MolodykhVY.Sprint4.TaskReview.V15.Lib;

namespace Tyuiu.MolodykhVY.Sprint4.TaskReview.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];

            string str = "10293847";

            DataService ds = new DataService();
            

            int index = 0;

            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;

                }
                Console.WriteLine();
            }

          
            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Количество нечетных чисел = " + res);
            Console.ReadKey();
        }
    }
}
