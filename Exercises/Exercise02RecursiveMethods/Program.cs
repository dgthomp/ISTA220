using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 10;
            int sum = 0;
            sum = get_sum(start, end, sum);
            Console.WriteLine($"The sum is {sum}");


        }
        private static int get_sum(int start, int end, int sum)
        {
            Console.WriteLine($"get_sum ({start}, {end}, {sum})");
            start = start + 1;
            sum = sum + start;
            if (start < end)
                return (get_sum(start, end, sum));
            else
                return (sum);
        }
    }
}
