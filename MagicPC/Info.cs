using System;
using static System.Console;

namespace MagicPC
{
    public class Info
    {
        public Info()
        {
        }
        public void DisplayInfo(string assignment)
        {
            WriteLine("**********************************************************************");
            WriteLine();
            WriteLine("\nName:\t\tAisha Kabir");
            WriteLine("Course:\t\tITDEV-115-200");
            WriteLine("Instructor:\tJanese Christie");
            WriteLine("Assignment:\t" + assignment);
            WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            WriteLine();
            WriteLine("**********************************************************************");
        }
    }
}
