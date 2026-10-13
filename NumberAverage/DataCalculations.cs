using System;
namespace NumberAverage
{
    public class DataCalculations
    {
        private double num1, num2, num3;

        public DataCalculations()
        { }


        public DataCalculations(double num1, double  num2, double num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public double Num3
        {
            get { return num3; }
            set { num3 = value; }
        }

        public double CalcAverage()
        {
            double average = 0;
            average = (num1 + num2 + num3) / 3;
            return average;
        }
    }
}
