using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_element_one_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            for(int cnt=0;cnt<3;cnt++)
            {
                Console.Write("enter element of arr1: ");
                arr1[cnt]=Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("copy process started :");
            for (int cnt = 0; cnt < 3; cnt++)
            {
                arr2[cnt] = arr1[cnt];
            }
            Console.WriteLine("copy process completed :");
            for (int cnt = 0; cnt < 3; cnt++)
            {
                Console.WriteLine("element of arr2:" + arr2[cnt]);
            }
            Console.ReadKey();


        }
    }
}
