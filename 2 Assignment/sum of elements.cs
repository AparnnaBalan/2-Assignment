using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Assignment
{
    class sum_of_elements
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int i, n, sum = 0;





            Console.Write("number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += array[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}", sum);
            Console.ReadLine();
        }
    }
}