using System;
using static System.Console;

namespace NumberAverage
{
    public class Presentation
    {

        public void UserDirections()
        {
            Clear();
            WriteLine("\n\nThis progran will show you how to separate the ");
            WriteLine("presentation layer from the data layer\n\n");

        }

        public double RequestUserData(int dataType)
        {
            string inValue;
            double number;

            WriteLine("Please enter number {0}: ", dataType);
            inValue = ReadLine();
            while (double.TryParse(inValue, out number) == false)
            {
                WriteLine("Error - Entry was not  a numerical data. Please enter a number\n\n");
                inValue = ReadLine();
            }
            return number;
        }

        public void DisplayResults(DataCalculations dataObject)
        {
            WriteLine("\n\nFirstNumber entered is {0}", dataObject.Num1);
            WriteLine("\n\nSecondtNumber entered is {0}", dataObject.Num2);
            WriteLine("\n\nThirdNumber entered is {0}", dataObject.Num3);
            WriteLine("\n\nThe average of the numbers is {0:F3}", dataObject.CalcAverage());
        }
    }
}
