using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int allscores = 10;
            int sumscores = 0;
            sumscores = grade(score, allscores, sumscores);
            Console.WriteLine($"Your Grade is: {sumscores}");


        }
        private static int grade(int score, int allscores, int sumcores)
        {
            Console.WriteLine($"get_sum ({score}, {allscores}, {sumcores})");
            score = score + 1;
            sumcores = sumcores + score;
            if (score < allscores)
                return (grade(score, allscores, sumcores));
            else
                return (sumcores);
        }
    }
}
