using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_row_col
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a2 = new int[2, 2];
            Console.WriteLine("Enter element of matrix[2,2]");
            for (int count = 0; count < 2; count++)
            {
                for (int count1 = 0; count1 < 2; count1++)
                {
                    a2[count, count1] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int count = 0; count < 2; count++)
            {
                int sum = 0;
                for (int count1 = 0; count1 < 2; count1++)
                {
                    sum += a2[count1, count1];
                }
                Console.WriteLine("sum of row =" + sum);

                for (int count1 = 0; count1 < 2; ++count1)
                {
                    sum = sum + a2[count1, count];
                }
                Console.WriteLine("sum of column=" + sum);
            }
            Console.ReadKey();
        }
       
    }

}
