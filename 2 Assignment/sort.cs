using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Assignment
{
    class sort
    {
        static void Main(string[] args)
        {

            int[] intArray = new int[] { 19, 34,56, 66, 78, 99

        };
            Console.WriteLine(" array");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sorted order");
            Array.Sort(intArray);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nSorted i order");
            Array.Reverse(intArray);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
           
            Console.ReadLine();

        }
    }
}

   