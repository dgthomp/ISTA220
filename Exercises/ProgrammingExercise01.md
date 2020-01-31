# **Class: ISTA220**
## **Name:**   Daniel Thompson
## **Assignment:** Programming Exercise01
## **Date:** January 16, 2020
~~~
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmingExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Circumference and Area of a Circle\n");
            Console.Write("Please enter an integer for the radius: ");
            string circleradius = Console.ReadLine();
            int intradius = int.Parse(circleradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The Circumference is { circumference}\n");
            double area = Math.PI * (intradius * intradius);
            Console.WriteLine($"The Area is  {area} \n");

            Console.WriteLine("Volume of a Hemisphere \n");
            Console.Write("Please enter an integer for the radius: ");
            string hemisphereradius = Console.ReadLine();
            int inthemisphereradius = int.Parse(hemisphereradius);
            double volume = 4 / 3 * Math.PI * inthemisphereradius * inthemisphereradius * inthemisphereradius / 2;
            Console.WriteLine($"The Volume of the Hemisphere is {volume}\n");

            Console.WriteLine("Area of a triangle (Heron's Formula \n");
            Console.Write("Enter the length of side a : ");
            string sidea = Console.ReadLine();
            int intsidea = int.Parse(sidea);
            Console.Write("Enter the length of side b : ");
            string sideb = Console.ReadLine();
            int intsideb = int.Parse(sideb);
            Console.Write("Enter the length of side c : ");
            string sidec = Console.ReadLine();
            int intsidec = int.Parse(sidec);
            int p = (intsidea + intsideb + intsidec) / 2;
            double areaTriangle = Math.Sqrt(p *(p-intsidea)*(p - intsideb)*(p - intsidec));
            Console.WriteLine($"The area of the trinagle is {areaTriangle}\n");

            Console.WriteLine("Solve expression using Quadratic Formula \n");
            Console.Write("Enter the value of a : ");
            string a = Console.ReadLine();
            int inta = int.Parse(a);
            Console.Write("Enter the value of b : ");
            string b = Console.ReadLine();
            int intb = int.Parse(b);
            Console.Write("Enter the value of c : ");
            string c = Console.ReadLine();
            int intc = int.Parse(c);
            //ax^2+bx+c
            //quadratic formula is (-b+-sqrt(b^2-4ac))/2a

            double L = intb * intb;
            double M = (-4) * (inta) * (intc);
            double N = Math.Sqrt(L + M);
            double O = (-1) * intb + N;
            double P = (-1) * intb - N;
            double Positive = O / 2 * inta;
            double Negative = P / 2 * inta;


            Console.WriteLine($"The positive solution is {Positive} ");
            Console.WriteLine($"The negative solution is {Negative}");

        }
    }
}



~~~
