using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleCalculator
{
    class RectangleCalculatorApp
    {
        public static void Main(string[] args)
        {
            AssignmentInfo("RectangleApp");
            double width;
            double height;
            double area;
            double perimeter;

            Directions();

            Dimensions dimensions = new Dimensions();
            height = dimensions.InputHeight();
            width = dimensions.InputWidth();
            area = dimensions.CalculateArea(height, width);
            perimeter = dimensions.CaculatePerimeter(height, width);

            Display(area, perimeter);

            ReadKey();
        }

        static void AssignmentInfo(string assignment)
        {
            WriteLine("**************************************************");
            WriteLine();
            WriteLine("\nName:\t\tAisha Kabir");
            WriteLine("Course:\t\tITDEV-115-200");
            WriteLine("Instructor:\tJanese Christie");
            WriteLine("Assignment:\t" + assignment);
            WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            WriteLine();
            WriteLine("**************************************************");
        }

        static void Directions()
        {
            WriteLine();
            WriteLine("This program will calculate the area and perimeter of a rectagle.");
            WriteLine("Begin by inputing the height and width of the rectangle.");
        }

        static void Display(double area, double perimeter)
        {
            WriteLine();
            WriteLine("The area of the rectangle is: "+ area);
            WriteLine("The perimeter of the rectangle is: "+ perimeter);
        }
    }
}
