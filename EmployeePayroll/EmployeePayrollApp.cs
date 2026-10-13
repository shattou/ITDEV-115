using System;
using static System.Console;


namespace EmployeePayroll
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Info info = new Info();
            info.AssignmentInfo("EmployeePayrollApp");
            Questions ask = new Questions();
            Employee employee = new Employee(ask.InputFirstName(), ask.InputLastName(), ask.InputSale());
            WriteLine(employee);
            ReadKey();

        }
    }
}
