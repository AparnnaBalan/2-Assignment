using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string str;
                int i, len, vowel, count;
                str = "hai";
                vowel = 0;
                count = 0;

                len = str.Length;
                for (i = 0; i < len; i++)
                {
                    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' ||
                        str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' ||
                        str[i] == 'O' || str[i] == 'U')
                    {
                        vowel++;
                    }
                    else
                    {
                        count++;
                    }
                }
                Console.Write("Vowels in the string: {0}", vowel);
                Console.ReadLine();
            }
        }
    }

}
    
