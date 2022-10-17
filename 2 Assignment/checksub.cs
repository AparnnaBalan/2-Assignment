using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Assignment
{
    class checksub
    {
        static void Main(string[] args)
        {
            String str = "apple";
            String value = "ma";
            Boolean result = str.Contains(value);
            Console.WriteLine($" string contain  substring?{result}");
            Console.ReadLine();
        }

    }
}
