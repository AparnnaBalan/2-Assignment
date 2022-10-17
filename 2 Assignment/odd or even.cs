using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Assignment
{
    class odd_or_even
    {
        static void Main(string[] args)
        {


            int even=0, odd=0;
            int[] arr;

            int[] array = new int[5]
                      {1,2,3,4,5};
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 == 0)
                {
                   even= even+1;
                }
                else
                {
                   odd= odd+1;
                }
            }

            Console.Write("Total even elements: {0}\n", + even);
            Console.Write("Total odd elements: {0}",+ odd);

            Console.ReadLine();
        }
    }
}
   
