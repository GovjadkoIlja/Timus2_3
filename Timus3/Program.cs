using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum;
            n=Convert.ToInt32(Console.ReadLine());
            if (n < 1)
                sum = -n * (n - 1) / 2+1;
            else
                sum= n * (n + 1) / 2;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
