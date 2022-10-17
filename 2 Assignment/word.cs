using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Assignment
{
    class word
    {
        public static void Main()
        {
            int a = 0, count = 1;
            string str = "this is a girl";
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    count++;
                }
                a++;
            }
            Console.Write("Number of words in string = {0}\n", count);
            Console.ReadLine();
        }
    }

}
