using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaCircumference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Circumference and Area of a Circle");
            Console.Write("Please enter an integer for the radius: ");
            string circleradius = Console.ReadLine();
            int intradius = int.Parse(circleradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The Circumference is { circumference}\n");
            double area = Math.PI * (intradius * intradius);
            Console.WriteLine($"The Area is  {area} \n");
            
            Console.WriteLine("Volume of a Hemisphere");
            Console.Write("Please enter an integer for the radius: ");
            string hemisphereradius = Console.ReadLine();
            int inthemisphereradius = int.Parse(hemisphereradius);
            double volume = 4 / 3 * Math.PI * inthemisphereradius * inthemisphereradius * inthemisphereradius / 2;
            Console.WriteLine($"The Volume of the Hemisphere is {volume}");
            

        }
    }
}
