using System;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area, perimeter;
            Console.WriteLine("Enter the radius of the circle");
            radius = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;
            Console.WriteLine("The perimeter of the circle is " + perimeter);
            Console.WriteLine("The area of the circle is " + area);
        }
    }
}
