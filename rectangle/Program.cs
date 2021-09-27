using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double fisrtS = Convert.ToDouble(Console.ReadLine());
            double secondS = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(fisrtS, secondS);
            Console.WriteLine($"S = {rectangle.AreaCalculator()}");
            Console.WriteLine($"P = {rectangle.PerimeterCalculator()}");
            Console.ReadKey();
        }
    }
    class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        public double AreaCalculator()
        {
            double area = Side1 * Side2;
            return area;
        }
        public double PerimeterCalculator()
        {
            double p = (Side1 + Side2) * 2;
            return p;
        }

    }
}
