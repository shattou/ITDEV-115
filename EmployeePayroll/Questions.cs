using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmployeePayroll
{
    public class Questions
    {
        public Questions()
        {
        }

        //public string EmployeeName(string whichOne)
        //{
        //    string name;
        //    WriteLine("Enter Employee's {0} name:\t", whichOne);
        //    name = ReadLine();
        //    return name;
        //}

        public string InputFirstName()
        {
            WriteLine("Please enter the employee's first name: ");
            string firstName = ReadLine();
            return firstName;
        }
        public string InputLastName()
        {
            WriteLine("Please enter the employee's last name: ");
            string lastName = ReadLine();
            return lastName;
        }

        public int InputSale()
        {
            WriteLine("Please enter the total sales for the month: ");
            int sales = int.Parse(ReadLine());
            return sales;

        }




    }
}
