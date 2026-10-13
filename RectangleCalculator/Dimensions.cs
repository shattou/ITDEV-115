using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleCalculator
{
    public class Dimensions
    {
        public double InputHeight()
        {
            WriteLine("Please enter the rectangle's height in inches: ");
            double height = double.Parse(ReadLine());
            return height;

        }
        public double InputWidth()
        {
            WriteLine("Please enter the rectangle's width in inches: ");
            double width = double.Parse(ReadLine());
            return width;
        }
        public double CalculateArea(double height, double width)
        {
            double area = height * width;
            return area;
        }
        public double CaculatePerimeter(double height, double width)
        {
            double perimeter = 2 * (height + width);
            return perimeter;
        }
    }
}
