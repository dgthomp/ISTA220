
# **Class: ISTA220**
## **Name:**   Daniel Thompson
## **Assignment:** ISTA220programmingexercise2*
## **Date:** February 10, 2020
~~~
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmingexercise2
{
class Program
{

string grade;
public Program(string g)
{

 grade = g;
}
public void printGrade()
{
 Console.WriteLine($"Your grade is {grade} ");
}
static void Main(string[] args)
{
 Console.Write("Please enter a test score:  ");
  string testscore = Console.ReadLine();
  double s = int.Parse(testscore);
  Console.WriteLine($"Your Score is {s}");
  CalculateGrade(s);

  Console.WriteLine("Part B: Please enter 10 test scores:");
  double sum = 0;
  double test = 1;
  double t =sum;
  sum = TenScores(t, test);
  double avg = (t + sum) / 10;
  Console.WriteLine($"Your average is {avg}");
  CalculateGrade(avg);

  Console.Write("Part C: How many test scores do you wish to enter: ");
  double end1 = double.Parse(Console.ReadLine());
  double sum1 = 0;
  double test1 = 1;
  double t1 = sum1;
  sum1 = userScores(t1, end1, test1);
  double avg1 = (t1 + sum1) / end1 ;
  Console.WriteLine($"Your average is {avg1}");
  CalculateGrade(avg1);

 Console.WriteLine("Part D: Please enter any number of test scores. TYPE -1 ONCE YOU ARE DONE:");
  double end2 = 0;
 double sum2 = 0;
 double test2 = 1;
 double t2 = sum1;
 sum1 = userScores2(t2, end2, test2);
 double avg2 = (t2 + sum2) / end2;
 Console.WriteLine($"Your average is {avg2}");
 CalculateGrade(avg2);

}

private static double userScores2(double t2, double end2, double test2)
{
 Console.Write($"Test {test2}: ");
 string usersum = Console.ReadLine();
 int usersum1 = int.Parse(usersum);
 double sum2 = double.Parse(usersum);

 if (usersum1 <= -1)

     return  sum2;
 else
     return userScores(t2 + sum2, end2, test2 + 1);
}

private static double userScores(double t1, double end1, double test1)
{
 Console.Write($"Test {test1}: ");
 double sum1 = int.Parse(Console.ReadLine());

 if (test1 == end1)
     return t1 + sum1;
 else
     return userScores(t1 + sum1, end1, test1 + 1);
}

private static double TenScores(double t, double test)
{

 Console.Write($"Test {test}: ");
 double sum = int.Parse(Console.ReadLine());

 if (test == 10)
     return t+sum;
     else
     return TenScores(t + sum, test + 1);


}
private static void CalculateGrade(double s)
{

 if (s >= 90)
 {
     Program A = new Program("A");

     A.printGrade();
 }
 else if (s >= 80)
 {
     Program B = new Program("B");

     B.printGrade();
 }
 else if (s >= 70)
 {
     Program C = new Program("C");

     C.printGrade();
 }
 else if (s >= 60)
 {
     Program D = new Program("D");

     D.printGrade();
 }
 else if (s < 60)
 {
     Program F = new Program("F");

     F.printGrade();

 }

}
}

}
~~~~
