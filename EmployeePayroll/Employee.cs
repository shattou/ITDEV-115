using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmployeePayroll
{
    public class Employee
    {

        private string firstName;
        private string lastName;
        private double sales;
        private double retirement;
        private const double CONTRIBUTION = 0.10;
        private const double FEDERALTAX = 0.18;
        private const double SOCIALSECURITY = 0.06;
        private const double COMMISSIONINCOME = 0.07;


        public Employee() { }

        public Employee(string firstName, string lastName, int sales)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sales = sales;

        }

        public double CalculateCommissionIncome()
        {
            return COMMISSIONINCOME * sales;
        }

        public double CalculateFederal()
        {
            return FEDERALTAX * sales;
        }
        public double CalculateSS()
        {
            return SOCIALSECURITY * sales;

        }

       public double RetirementContribution
        {
            get
            {
                return sales * CONTRIBUTION;
            }

            set
            {
                retirement = value;
            }

        }

        public override string ToString()
        {
            return "\nName:\t\t" + firstName + " " + lastName +
                "\nEmployee Gross Income:\t\t$" + sales +
                "\nFederal Tax Withheld: \t\t$" + CalculateFederal() +
                "\nSocial Security Tax Withheld: \t$" + CalculateSS() +
                "\nRetirement Contribution: \t$" + RetirementContribution +
                "\n\nEmployee Net Pay: \t\t$" + (sales - CalculateFederal() - CalculateSS() - CalculateCommissionIncome() - retirement);
                ;
        }

    }

}
