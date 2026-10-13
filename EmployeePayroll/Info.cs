using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmployeePayroll
{
    public class Info
    {
        public Info()
        {

        }

        public void AssignmentInfo(string assignment)
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
    }
}
