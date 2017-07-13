using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static ulong Factorial(ulong a, ulong b)
        {
            ulong n = a;
            for (ulong i = a; i < b; i++)
                n = n * i;
            return n;
        }

        static void Main(string[] args)
        {
            StreamReader fs = new StreamReader(@"INPUT.TXT");
            string[] str = fs.ReadLine().Split(' ');
            ulong n = ulong.Parse(str[0]);
            ulong a = ulong.Parse(str[1]);
            ulong b = ulong.Parse(str[2]);
            ulong resultA = Factorial(a, a + n) / Factorial(1, n);
            ulong resultB = Factorial(b, b + n) / Factorial(1, n);
            ulong result = 0;
            if (resultA == 0) result = resultB;
            else if (resultB == 0) result = resultA;
            else result = resultA * resultB;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
