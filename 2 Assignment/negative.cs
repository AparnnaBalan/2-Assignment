using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Assignment
{
    class negative
    {

        static void Main()
        {
            int n;
            int[] arr = new int[100];
            int[] newarr = new int[10];


            Console.WriteLine("Enter array elements : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("store negative numbers : ");
            for (int i = 0; i <n; i++)
            {
                if (arr[i] < 0)
                {
                   

                    Console.Write(arr[i] + " ");
                }
            }

                Console.ReadLine();
            }
        }
    }

  