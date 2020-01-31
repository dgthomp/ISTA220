using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of integers to add: ");
            string strNumber = Console.ReadLine();
            int end = Int32.Parse(strNumber);
            int start = 0;
            int sum = 0;
            sum = GetSums(start, end, sum);
            Console.WriteLine($"the sum is { sum}");
        }
        private static int GetSums(int start, int end, int sum)
        {
            if (start <= end)
            {
                Console.WriteLine("The sum of " + start + " and " + sum + " is " + (sum + start));
                sum = start + sum;
                start = start + 1;
                return (GetSums(start, end, sum));
            }
            else
            {
                return (sum);
            }
        }

    }
}
